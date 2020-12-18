using GothamSubway.Data;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GothamSubway.Importer
{
    public partial class ImporterForm : Form
    {
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Application application;
        List<string> columns;
        List<List<string>> rows;
        private int _checkedRadioButton;

        public ImporterForm()
        {
            InitializeComponent();

            workbook = null;
            worksheet = null;
            application = null;
            _checkedRadioButton = 0;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                bgwLoader.RunWorkerAsync(openFileDialog1.FileName);
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            if (_checkedRadioButton <= 0 || _checkedRadioButton > 4) // 나중에 상수로 바꾸자
            {
                MessageBox.Show("저장 방식을 선택해 주세요");
                return;
            }

            bgwInsert.RunWorkerAsync(_checkedRadioButton);
        }
        private void GetExcelData(List<List<string>> r, List<string> w)
        {
            rows = new List<List<string>>();
            columns = new List<string>();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"파일명 : \n{openFileDialog1.FileName}");

                application = new Excel.Application();
                workbook = application.Workbooks.Open(openFileDialog1.FileName);
                worksheet = workbook.Sheets[1];
                application.Visible = false;

                Range range = worksheet.UsedRange;

                for (int i = 1; i <= (range.Rows.Count > 100 ? 100 : range.Rows.Count); ++i)
                {
                    if (i != 1)
                        rows.Add(new List<string>());

                    for (int j = 1; j <= range.Columns.Count; ++j)
                    {
                        if (i == 1) // 첫째줄이면?
                        {
                            if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                                columns.Add(((Range)range.Cells[i, j]).Value2.ToString());
                        }
                        else
                        {
                            if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                                rows[i - 2].Add(((Range)range.Cells[i, j]).Value2.ToString());
                        }
                    }
                }

                ReleaseObject(range);
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                application.Quit();
                ReleaseObject(application);
            }
        }
        static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj); // 액셀 객체 해제
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect(); // 가비지 수집
            }
        }
        private void AddGridView(DataGridView view, List<string> c, List<List<string>> r)
        {
            view.Rows.Clear();
            view.Columns.Clear();

            foreach (string column in columns)
            {
                view.ColumnCount += 1;
                view.Columns[this.dgvViewer.Columns.Count - 1].HeaderText = column;
                view.Columns[this.dgvViewer.Columns.Count - 1].Name = column;
            }

            foreach (List<string> row in rows)
            {
                view.Rows.Add(row.ToArray());
            }
        }

        private void bgwLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            rows = new List<List<string>>();
            columns = new List<string>();

            application = new Excel.Application();
            workbook = application.Workbooks.Open((string)e.Argument);
            worksheet = workbook.Sheets[1];
            application.Visible = false;

            Range range = worksheet.UsedRange;

            for (int i = 1; i <= range.Rows.Count; ++i)
            {
                if (i != 1)
                    rows.Add(new List<string>());

                for (int j = 1; j <= range.Columns.Count; ++j)
                {
                    if (i == 1) // 첫째줄이면?
                    {
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            columns.Add(((Range)range.Cells[i, j]).Value2.ToString());
                    }
                    else
                    {
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            rows[i - 2].Add(((Range)range.Cells[i, j]).Value2.ToString());
                    }
                }

                bgwLoader.ReportProgress(0, i.ToString());
            }

            ReleaseObject(range);
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            application.Quit();
            ReleaseObject(application);
        }

        private void bgwLoader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress.Text = $"읽어들인 행 : {(string)e.UserState}";
        }

        private void bgwLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvViewer.Rows.Clear();
            dgvViewer.Columns.Clear();

            foreach (string column in columns)
            {
                dgvViewer.ColumnCount += 1;
                dgvViewer.Columns[dgvViewer.Columns.Count - 1].HeaderText = column;
                dgvViewer.Columns[dgvViewer.Columns.Count - 1].Name = column;
            }

            foreach (List<string> row in rows.GetRange(0, (rows.Count > 100 ? 100 : rows.Count)))
            {
                dgvViewer.Rows.Add(row.ToArray());
            }
        }

        private void bgwInsert_DoWork(object sender, DoWorkEventArgs e)
        {
            Random random = new Random();

            if ((int)e.Argument == 1)
            {

                // Entity에 값 넣기
                List<Station> stations = new List<Station>();
                List<FootTraffic> footTraffics = new List<FootTraffic>();
                List<SubwayCard> subwayCards = new List<SubwayCard>();
                List<Revenue> revenues = new List<Revenue>();
                List<Transfer> transfers = new List<Transfer>();

                using (var context = DbContextCreator.Create())
                {
                    footTraffics = context.FootTraffics.ToList();
                    stations = context.Stations.ToList();
                    subwayCards = context.SubwayCards.ToList();
                    transfers = context.Transfers.ToList();
                }

                for (int i = 0; i < rows.Count; ++i)
                {
                    // Station
                    Station station = new Station();
                    if (stations.Find(x => x.Name == rows[i][1]) == null)
                    {
                        // 역이 없을 경우 추가해주기
                        station.Name = rows[i][1];
                        stations.Add(station);
                    }
                    else
                        // 역이 있을 경우 연결
                        station = stations.Find(x => x.Name == rows[i][1]);

                    // FootTraffic
                    FootTraffic footTraffic = new FootTraffic() { Station = station, TransferId = transfers.Find(x => x.Name == rows[i][2]).TransferId };

                    double dateNumber = 0;
                    dateNumber = double.Parse(rows[i][0]);
                    if (dateNumber > 60d)
                        dateNumber = dateNumber - 2;
                    else
                        dateNumber = dateNumber - 1;

                    DateTime dateTime = new DateTime(1900, 1, 1);
                    dateTime = dateTime.AddDays(dateNumber);

                    footTraffic.Date = dateTime;
                    footTraffic.BeforeSix = int.Parse(rows[i][3]);
                    footTraffic.SixToSeven = int.Parse(rows[i][4]);
                    footTraffic.SevenToEight = int.Parse(rows[i][5]);
                    footTraffic.EightToNine = int.Parse(rows[i][6]);
                    footTraffic.NineToTen = int.Parse(rows[i][7]);
                    footTraffic.TenToEleven = int.Parse(rows[i][8]);
                    footTraffic.ElevenToTwelve = int.Parse(rows[i][9]);
                    footTraffic.TwelveToThirteen = int.Parse(rows[i][10]);
                    footTraffic.ThirteenToFourteen = int.Parse(rows[i][11]);
                    footTraffic.FourteenToFifteen = int.Parse(rows[i][12]);
                    footTraffic.FifteenToSixteen = int.Parse(rows[i][13]);
                    footTraffic.SixteenToSeventeen = int.Parse(rows[i][14]);
                    footTraffic.SeventeenToEighteen = int.Parse(rows[i][15]);
                    footTraffic.EighteenToNineteen = int.Parse(rows[i][16]);
                    footTraffic.NineteenToTwenty = int.Parse(rows[i][17]);
                    footTraffic.TwentyToTwentyOne = int.Parse(rows[i][18]);
                    footTraffic.TwnetyOneToTwentyTwo = int.Parse(rows[i][19]);
                    footTraffic.TwentyTwoToTwentyThree = int.Parse(rows[i][20]);
                    footTraffic.TwentyThreeToTwentyFour = int.Parse(rows[i][21]);
                    footTraffic.AfterTwentyFour = int.Parse(rows[i][22]);

                    footTraffics.Add(footTraffic);
                }

                //SubwayCard
                // 1.Wayne shipping, 2.DK Transport, 3.Gotham Credit
                List<SubwayCard> subwayCardList = new List<SubwayCard>();
                subwayCardList.Add(new SubwayCard() { CompanyName = "Wayne shipping" });
                subwayCardList.Add(new SubwayCard() { CompanyName = "DK Transport" });
                subwayCardList.Add(new SubwayCard() { CompanyName = "Gotham Credit" });
                subwayCards.AddRange(subwayCardList);

                for (int i = 1; i <= 12; i++)
                {
                    for (int j = 0; j < stations.Count; j++)
                    {
                        List<FootTraffic> list = footTraffics.FindAll(x => x.Date.Month == i && x.StationId == (j + 1));
                        int sum = 0;
                        foreach (var item in list)
                        {
                            sum = item.BeforeSix + item.SixToSeven + item.SevenToEight + item.EightToNine +
                                item.NineToTen + item.TenToEleven + item.ElevenToTwelve + item.TwelveToThirteen +
                                item.ThirteenToFourteen + item.FourteenToFifteen + item.FifteenToSixteen + item.SixteenToSeventeen +
                                item.SeventeenToEighteen + item.EighteenToNineteen + item.NineteenToTwenty + item.TwentyToTwentyOne +
                                item.TwnetyOneToTwentyTwo + item.TwentyTwoToTwentyThree + item.TwentyThreeToTwentyFour + item.AfterTwentyFour;
                        }
                        sum *= 1300;
                        for (int k = 0; k < 3; k++)
                        {
                            Revenue revenue = new Revenue();
                            revenue.StationId = j + 1;
                            revenue.Month = new DateTime(list.First().Date.Year - 1, i, 1);
                            revenue.SubwayCardId = k + 1;
                            if (k < 2)
                            {
                                int income = (int)(sum * (random.NextDouble() % 0.4));
                                revenue.Income = income;
                                sum -= income;
                            }
                            else
                            {
                                revenue.Income = sum;
                                sum = 0;
                            }
                            revenues.Add(revenue);
                        }
                    }
                }

                // Entity를 DB에 저장
                using (var context = DbContextCreator.Create())
                {
                    for (int i = context.Stations.Count(); i < stations.Count; i++)
                        context.Stations.Add(stations[i]);
                    for (int i = context.SubwayCards.Count(); i < subwayCards.Count; i++)
                        context.SubwayCards.Add(subwayCards[i]);
                    context.FootTraffics.AddRange(footTraffics);
                    context.Revenues.AddRange(revenues);
                    context.SaveChanges();
                }
            }
            else if ((int)e.Argument == 2)
            {
                // Entity에 값 넣기
                List<Satisfaction> satisfactions = new List<Satisfaction>();
                List<SatisfactionCategory> satisfactionCategories = new List<SatisfactionCategory>();
                int maxFirstId;
                int beforeSatisfactionCategoryCount;

                using (var context = DbContextCreator.Create())
                {
                    satisfactionCategories = context.SatisfactionCategories.ToList();
                    if (satisfactionCategories.Count != 0)
                        maxFirstId = (context.SatisfactionCategories.Max(x => x.SatisfactionCategoryId)) / 100;
                    else
                        maxFirstId = 1;
                    beforeSatisfactionCategoryCount = satisfactionCategories.Count;
                }

                for (int i = 0; i < rows.Count; ++i)
                {
                    // SatisfactionCategory
                    SatisfactionCategory firstSatisfactionCategory = new SatisfactionCategory();
                    // 카테고리1이 없을 떄 만들어주기
                    if (satisfactionCategories.Find(x => x.Item == rows[i][0]) == null)
                    {
                        firstSatisfactionCategory.Item = rows[i][0];
                        firstSatisfactionCategory.SatisfactionCategoryId = maxFirstId * 100;
                        maxFirstId += 1;
                        satisfactionCategories.Add(firstSatisfactionCategory);
                    }

                    int upperId = satisfactionCategories.Find(x => x.Item == rows[i][0]).SatisfactionCategoryId;

                    SatisfactionCategory secondSatisfactionCategory = new SatisfactionCategory();
                    // 카테고리2가 없을 때, 또는 카테고리2가 있는데 카테고리1이 다를 때
                    if (satisfactionCategories.Find(x => x.Item == rows[i][1]) == null ||
                        ((satisfactionCategories.Find(x => x.Item == rows[i][1]) != null) &&
                        satisfactionCategories.Find(x => x.Item == rows[i][1]).UpperId != upperId))
                    {
                        secondSatisfactionCategory.Item = rows[i][1];
                        secondSatisfactionCategory.UpperId = upperId;
                        if (satisfactionCategories.Find(x => x.UpperId == upperId) == null)
                            secondSatisfactionCategory.SatisfactionCategoryId = upperId + 1;
                        else
                            secondSatisfactionCategory.SatisfactionCategoryId =
                                satisfactionCategories.Where(x => x.UpperId == upperId).Max(x => x.SatisfactionCategoryId) + 1;
                        secondSatisfactionCategory.SatisfactionCategory2 = satisfactionCategories.Find(x => x.SatisfactionCategoryId == secondSatisfactionCategory.UpperId);
                        satisfactionCategories.Add(secondSatisfactionCategory);
                    }
                    else
                        secondSatisfactionCategory = satisfactionCategories.Find(x => x.Item == rows[i][1] && x.UpperId == upperId);

                    // Satisfaction
                    Satisfaction satisfaction = new Satisfaction() { SatisfactionCategory = secondSatisfactionCategory };
                    satisfaction.Excellent = decimal.Parse(rows[i][2]);
                    satisfaction.Good = decimal.Parse(rows[i][3]);
                    satisfaction.Soso = decimal.Parse(rows[i][4]);
                    satisfaction.Bad = decimal.Parse(rows[i][5]);
                    satisfaction.Terrible = decimal.Parse(rows[i][6]);

                    satisfactions.Add(satisfaction);
                }

                foreach (var s in satisfactionCategories)
                {
                    if (s.SatisfactionCategoryId == 0)
                        bgwInsert.ReportProgress(0, "error");
                }

                // Entity를 DB에 저장
                using (var context = DbContextCreator.Create())
                {
                    for (int i = beforeSatisfactionCategoryCount; i < satisfactionCategories.Count; ++i)
                        context.SatisfactionCategories.Add(satisfactionCategories[i]);
                    context.Satisfactions.AddRange(satisfactions);
                    context.SaveChanges();
                }
            }
            else if ((int)e.Argument == 3)
            {
                // Entity에 값 넣기
                List<Electricity> electricities = new List<Electricity>();

                for (int i = 0; i < rows.Count; ++i)
                {
                    Electricity electricity = new Electricity();

                    double dateNumber = 0;
                    dateNumber = double.Parse(rows[i][0]);
                    if (dateNumber > 60d)
                        dateNumber = dateNumber - 2;
                    else
                        dateNumber = dateNumber - 1;

                    DateTime dateTime = new DateTime(1900, 1, 1);
                    dateTime = dateTime.AddDays(dateNumber);

                    electricity.Month = dateTime;
                    electricity.Usage = int.Parse(rows[i][1]);
                    electricity.Bill = int.Parse(rows[i][2]);

                    electricities.Add(electricity);

                    bgwInsert.ReportProgress(0, i.ToString());
                }

                // Entity를 DB에 저장하기
                using (var context = DbContextCreator.Create())
                {
                    //foreach (Electricity electricity in electricities)
                    context.Electricities.AddRange(electricities);
                    context.SaveChanges();
                }
            }
            else if ((int)e.Argument == 4)
            {
                // Satisfaction
                List<Satisfaction> satisfactions = Dao.Satisfaction.GetAll();
                List<Satisfaction> newSatisfactions = new List<Satisfaction>();

                for (int i = 0; i < satisfactions.Count; i++)
                {
                    List<int> randomNumbers = new List<int>();
                    int sum = 0;

                    for (int j = 0; j < 5; j++)
                    {
                        randomNumbers.Add(random.Next(1500, 2000));
                        sum += randomNumbers[j];
                    }

                    Satisfaction satisfaction = new Satisfaction()
                    {
                        SatisfactionCategoryId = satisfactions[i].SatisfactionCategoryId,
                        Excellent = (decimal)((randomNumbers[0] * 100.0) / (double)sum),
                        Good = (decimal)((randomNumbers[1] * 100.0) / (double)sum),
                        Soso = (decimal)((randomNumbers[2] * 100.0) / (double)sum),
                        Bad = (decimal)((randomNumbers[3] * 100.0) / (double)sum),
                        Terrible = (decimal)((randomNumbers[4] * 100.0) / (double)sum)
                    };

                    newSatisfactions.Add(satisfaction);
                }

                using (var context = DbContextCreator.Create())
                {
                    context.Satisfactions.AddRange(newSatisfactions);
                    context.SaveChanges();
                }
            }
        }

        private void bgwInsert_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgress2.Text = $"변환된 행 : {(string)e.UserState}";
        }

        private void bgwInsert_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("완료");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;
            _checkedRadioButton = int.Parse(checkedRadioButton.Tag.ToString());
        }
    }
}