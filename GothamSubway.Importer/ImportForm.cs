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
    public partial class ImportForm : Form
    {
        List<List<string>> rows;
        private int _checkedRadioButton;
        public ImportForm()
        {
            InitializeComponent();
            _checkedRadioButton = 0;
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (CheckRadioButtonChecked() == false)
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                bgwLoader.RunWorkerAsync(openFileDialog1.FileName);
        }
        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            if (CheckRadioButtonChecked() == false)
                return;

            bgwInsert.RunWorkerAsync(_checkedRadioButton);
        }
        private bool CheckRadioButtonChecked()
        {
            if (_checkedRadioButton == 0)
            {
                MessageBox.Show("저장 방식을 선택해 주세요");
                return false;
            }
            return true;
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
        private DateTime ParsingDateTime(string v)
        {
            double dateNumber;
            double.TryParse(v, out dateNumber);

            if (dateNumber == 0d) return new DateTime(1900, 1, 1);

            if (dateNumber > 60d)
                dateNumber = dateNumber - 2;
            else
                dateNumber = dateNumber - 1;

            DateTime dateTime = new DateTime(1900, 1, 1);
            return dateTime.AddDays(dateNumber);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkedRadioButton = sender as RadioButton;
            _checkedRadioButton = int.Parse(checkedRadioButton.Tag.ToString());

            dgvViewer.Columns.Clear();

            foreach (string column in ImportColumns.GetColumns(_checkedRadioButton))
            {
                dgvViewer.ColumnCount += 1;
                dgvViewer.Columns[dgvViewer.Columns.Count - 1].HeaderText = column;
                dgvViewer.Columns[dgvViewer.Columns.Count - 1].Name = column;
            }
        }
        private void bgwLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            rows = new List<List<string>>();

            Excel.Application application = new Excel.Application();
            Workbook workbook = application.Workbooks.Open((string)e.Argument);
            Worksheet worksheet = workbook.Sheets[1];
            application.Visible = false;
            Range range = worksheet.UsedRange;

            // 첫째줄은 안받음
            for (int i = 2; i <= range.Rows.Count; ++i)
            {
                rows.Add(new List<string>());

                for (int j = 1; j <= range.Columns.Count; ++j)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        rows[i - 2].Add((range.Cells[i, j] as Range).Value2.ToString());
                }

                bgwLoader.ReportProgress(0, (i - 1).ToString());
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

            foreach (List<string> row in rows.GetRange(0, (rows.Count > 100 ? 100 : rows.Count)))
            {
                dgvViewer.Rows.Add(row.GetRange(0, dgvViewer.ColumnCount).ToArray());
                dgvViewer.Rows[dgvViewer.Rows.Count - 2].Cells[0].Value = 
                    ParsingDateTime(dgvViewer.Rows[dgvViewer.Rows.Count - 2].Cells[0].Value.ToString()).ToShortDateString();
            }

            Utility.Mbox("알림", "불러오기가 완료되었습니다.\n읽은 파일의 내용을 확인해주세요.\n잘못 입력된 파일은 데이터베이스의 손상으로 이어질 수 있습니다.");
        }
        private void bgwInsert_DoWork(object sender, DoWorkEventArgs e)
        {
            Random random = new Random();

            if ((int)e.Argument == 1)
            {
                using (var context = DbContextCreator.Create())
                {
                    for(int i =0; i < rows.Count; ++i)
                    {
                        Station station = context.Stations.Where(x => x.Name == rows[i][1]).FirstOrDefault();
                        if (station == null)
                        {
                            // 역이 없을 경우 추가
                            station.Name = rows[i][1];
                            context.Stations.Add(station);
                        }

                        FootTraffic footTraffic = new FootTraffic()
                        {
                            Date = ParsingDateTime(rows[i][0]),
                            Station = station,
                            Transfer = context.Transfers.Where(x => x.Name == rows[i][2]).FirstOrDefault(),
                            BeforeSix = int.Parse(rows[i][3]),
                            SixToSeven = int.Parse(rows[i][4]),
                            SevenToEight = int.Parse(rows[i][5]),
                            EightToNine = int.Parse(rows[i][6]),
                            NineToTen = int.Parse(rows[i][7]),
                            TenToEleven = int.Parse(rows[i][8]),
                            ElevenToTwelve = int.Parse(rows[i][9]),
                            TwelveToThirteen = int.Parse(rows[i][10]),
                            ThirteenToFourteen = int.Parse(rows[i][11]),
                            FourteenToFifteen = int.Parse(rows[i][12]),
                            FifteenToSixteen = int.Parse(rows[i][13]),
                            SixteenToSeventeen = int.Parse(rows[i][14]),
                            SeventeenToEighteen = int.Parse(rows[i][15]),
                            EighteenToNineteen = int.Parse(rows[i][16]),
                            NineteenToTwenty = int.Parse(rows[i][17]),
                            TwentyToTwentyOne = int.Parse(rows[i][18]),
                            TwnetyOneToTwentyTwo = int.Parse(rows[i][19]),
                            TwentyTwoToTwentyThree = int.Parse(rows[i][20]),
                            TwentyThreeToTwentyFour = int.Parse(rows[i][21]),
                            AfterTwentyFour = int.Parse(rows[i][22])
                        };

                        context.FootTraffics.Add(footTraffic);
                        bgwInsert.ReportProgress(0, i.ToString());
                    }

                    context.SaveChanges();
                }
            }
            else if ((int)e.Argument == 2)
            {
                using (var context = DbContextCreator.Create())
                {
                    int maxFirstId = (context.SatisfactionCategories.Max(x => x.SatisfactionCategoryId)) / 100;

                    for(int i =0; i < rows.Count; ++i)
                    {
                        // 카테고리 검사
                        SatisfactionCategory first = context.SatisfactionCategories
                            .Where(x => x.Item == rows[i][1]).FirstOrDefault();
                        if (first == null)
                        {
                            // 카테고리1이 없을 때
                            first = new SatisfactionCategory();
                            first.Item = rows[i][1];
                            first.SatisfactionCategoryId = maxFirstId * 100;
                            maxFirstId += 1;
                            context.SatisfactionCategories.Add(first);
                        }

                        int upperId = first.SatisfactionCategoryId;

                        SatisfactionCategory second = context.SatisfactionCategories
                            .Where(x => x.Item == rows[i][2]).FirstOrDefault();
                        if(second == null || (second != null && second.UpperId != upperId))
                        {
                            // 카테고리2가 없을 때, 또는 카테고리2가 있는데 카테고리1이 다를 때
                            second.Item = rows[i][2];
                            second.UpperId = upperId;
                            SatisfactionCategory upper = context.SatisfactionCategories.Where(x => x.UpperId == upperId).FirstOrDefault();
                            if(upper == null)
                                second.SatisfactionCategoryId = upperId + 1;
                            else
                                second.SatisfactionCategoryId = upper.SatisfactionCategoryId + 1;
                            second.SatisfactionCategory2 = first;
                            context.SatisfactionCategories.Add(second);
                        }

                        // Satisfaction
                        Satisfaction satisfaction = new Satisfaction()
                        {
                            Year = ParsingDateTime(rows[i][0]),
                            SatisfactionCategory = second,
                            Excellent = decimal.Parse(rows[i][3]),
                            Good = decimal.Parse(rows[i][4]),
                            Soso = decimal.Parse(rows[i][5]),
                            Bad = decimal.Parse(rows[i][6]),
                            Terrible = decimal.Parse(rows[i][7])
                        };
                    }

                    context.SaveChanges();
                }
            }
            else if ((int)e.Argument == 3)
            {
                // 날짜 전력사용량 전기요금

                using (var context = DbContextCreator.Create())
                {

                    List<Electricity> electricities = new List<Electricity>();

                    for (int i = 0; i < rows.Count; ++i)
                    {
                        Electricity electricity = new Electricity();
                        electricity.Month = ParsingDateTime(rows[i][0]);
                        electricity.Usage = int.Parse(rows[i][1]);
                        electricity.Bill = int.Parse(rows[i][2]);

                        context.Electricities.Add(electricity);
                        bgwInsert.ReportProgress(0, i.ToString());
                    }

                    context.SaveChanges();
                }
            }
            else if ((int)e.Argument == 4)
            {
                // 날짜 역명 카드사 수입

                //SubwayCard
                // 1.Wayne shipping, 2.DK Transport, 3.Gotham Credit

                using (var context = DbContextCreator.Create())
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        Revenue revenue = new Revenue()
                        {
                            Station = context.Stations.Where(x => x.Name == rows[i][1]).FirstOrDefault(),
                            SubwayCard = context.SubwayCards.Where(x => x.CompanyName == rows[i][2]).FirstOrDefault(),
                            Month = ParsingDateTime(rows[i][0]),
                            Income = int.Parse(rows[i][3])
                        };

                        context.Revenues.Add(revenue);
                        bgwInsert.ReportProgress(0, i.ToString());
                    }

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
        internal class ImportColumns
        {
            public static List<string> GetColumns(int num)
            {
                if (num == 1)
                    return GetFootTraffic();
                else if (num == 2)
                    return GetSatisfaction();
                else if (num == 3)
                    return GetElectricity();
                else
                    return GetRevenue();
            }

            public static List<string> GetFootTraffic()
            {
                return new List<string>() { "날짜(일)", "역명", "구분", "06시이전", "06~07", "07~08", "08~09",
                "09~10", "10~11", "11~12", "12~13", "13~14", "14~15", "15~16", "16~17", "18~19", "19~20",
                "20~21", "21~22", "22~23", "23~24", "24시이후" };
            }

            public static List<string> GetSatisfaction()
            {
                return new List<string>() { "날짜(년)", "특성별(1)", "특성별(2)", "매우 만족(%)", "약간 만족(%)",
                "보통(%)", "약간 불만족(%)", "매우 불만족(%)" };
            }

            public static List<string> GetElectricity()
            {
                return new List<string>() { "날짜(월)", "전력사용량", "전기요금" };
            }

            public static List<string> GetRevenue()
            {
                return new List<string>() { "날짜(월)", "역명", "카드사", "수입" };
            }
        }
    }
}