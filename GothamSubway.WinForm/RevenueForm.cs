using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using GothamSubway.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GothamSubway.WinForm
{
    public partial class RevenueForm : XtraForm
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        public int SelectedYear { get; set; }
        public int SelectedStation { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            SelectedStation = 0;
            SelectedYear = 2019;

            revenueBindingSource.DataSource = Dao.Revenue.GetAll();

            gothamMapControl.ButtonClicked += GothamMapControl_ButtonClicked;
            gothamMapControl.InitButton();

            yearSelectorControl1.SelectComboBox += YearSelectorControl1_SelectComboBox;
            yearSelectorControl1.Initialize(Dao.Revenue.GetAllYears());
        }

        private void Resume()
        {
            for(int i =0; i < Dao.SubwayCard.GetCount(); ++i)
            {
                Series series = chartControl1.Series[i];
                series.FilterString = 
                    $"[StationId] = {SelectedStation} " +
                    $"And [SubWayCardId] = {i + 1} " +
                    $"And [Month] Between(#{SelectedYear}-01-01#, #{SelectedYear}- 12-31#)";
            }

            ResumeLayout(false);
        }

        private void GothamMapControl_ButtonClicked(object sender, GothamMapControl1.ButtonClickedEventArgs e)
        {
            SelectedStation = e.StationNumber;
            Resume();
        }

        private void YearSelectorControl1_SelectComboBox(object sender, YearSelectorControl.SelectComboBoxEventArgs e)
        {
            SelectedYear = e.Item;
            Resume();
        }
    }
}
