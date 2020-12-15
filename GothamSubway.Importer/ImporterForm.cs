using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        public ImporterForm()
        {
            InitializeComponent();

            workbook = null;
            worksheet = null;
            application = null;
        }

        private void GetExcelData(List<List<string>> rows, List<string> columns)
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

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            GetExcelData(rows, columns);

            AddGridView(dataGridView1, columns, rows);
        }

        private void AddGridView(DataGridView view, List<string> columns, List<List<string>> rows)
        {
            view.Rows.Clear();
            view.RowCount = 0;
            view.Columns.Clear();
            view.ColumnCount = 0;

            foreach (string column in columns)
            {
                view.ColumnCount += 1;
                view.Columns[this.dataGridView1.Columns.Count - 1].HeaderText = column;
                view.Columns[this.dataGridView1.Columns.Count - 1].Name = column;
            }

            foreach (List<string> row in rows)
            {
                view.Rows.Add(row.ToArray());
            }
        }
    }
}