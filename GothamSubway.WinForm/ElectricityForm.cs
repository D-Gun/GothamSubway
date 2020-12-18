using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using GothamSubway.Data;

namespace GothamSubway.WinForm
{
    public partial class ElectricityForm : XtraForm
    {
        public ElectricityForm()
        {
            InitializeComponent();
            SelectedYear = 2019;
        }

        public int SelectedYear { get; set; }
        public List<ElectricityItem> ElectricityItems = Dao.Electricity.GetElectricity();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            yearSelectorControl1.SelectComboBox += YearSelectorControl1_SelectComboBox;
            List<int> years = Dao.Electricity.GetAllYears();
            years.Sort();
            years.RemoveAt(0);
            yearSelectorControl1.Initialize(years);
        }

        private void Resume()
        {
            chartUsage.Series[0].FilterString = $" [Month] Between(#{SelectedYear - 1}-01-01#, #{SelectedYear - 1}- 12-31#)";
            chartUsage.Series[0].Name = $"{SelectedYear - 1}년";
            chartUsage.Series[1].FilterString = $" [Month] Between(#{SelectedYear}-01-01#, #{SelectedYear}- 12-31#)";
            chartUsage.Series[1].Name = $"{SelectedYear}년";
            chartUsage.Series[2].FilterString = $" [Month] Between(#{SelectedYear}-01-01#, #{SelectedYear}- 12-31#)";

            chartBill.Series[0].FilterString = $" [Month] Between(#{SelectedYear - 1}-01-01#, #{SelectedYear - 1}- 12-31#)";
            chartBill.Series[0].Name = $"{SelectedYear - 1}년";
            chartBill.Series[1].FilterString = $" [Month] Between(#{SelectedYear}-01-01#, #{SelectedYear}- 12-31#)";
            chartBill.Series[1].Name = $"{SelectedYear}년";
            chartBill.Series[2].FilterString = $" [Month] Between(#{SelectedYear}-01-01#, #{SelectedYear}- 12-31#)";

            electricityBindingSource.DataSource = ElectricityItems.Where(x => x.Month.Year == SelectedYear -1 || x.Month.Year == SelectedYear);
            ResumeLayout(false);
        }

        private void YearSelectorControl1_SelectComboBox(object sender, YearSelectorControl.SelectComboBoxEventArgs e)
        {
            SelectedYear = e.Item;
            Resume();
        }
    }
}
