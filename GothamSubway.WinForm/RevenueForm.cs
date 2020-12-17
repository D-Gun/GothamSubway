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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            revenueBindingSource.DataSource = Dao.Revenue.GetAll();

            Dao.Revenue.GetAllYears();

            yearSelectorControl1.SelectComboBox += YearSelectorControl1_SelectComboBox;
            yearSelectorControl1.Initialize(Dao.Revenue.GetAllYears());

            gothamMapControl.ButtonClicked += GothamMapControl_ButtonClicked;
            

        }

        private void GothamMapControl_ButtonClicked(object sender, GothamMapControl1.ButtonClickedEventArgs e)
        {
            //for(int i = 0; i < Dao.SubwayCard.GetCount(); ++i)
            //{
            //    Series series = chartControl1.Series[i];
            //    series.FilterString = $"[StationId] = {e.}"
            //}

            //foreach (Series serise in chartControl1.Series)
            //{
            //    serise.FilterString = "[StationId] = 1 And [SubwayCardId] = 3";
            //}
        }

        private void YearSelectorControl1_SelectComboBox(object sender, YearSelectorControl.SelectComboBoxEventArgs e)
        {
            for (int i = 0; i < Dao.SubwayCard.GetCount(); ++i)
            {
                Series series = chartControl1.Series[i];
                series.FilterString = $"[StationId] = 1 And [SubWayCardId] = {i+1} And [Month] Between(#{e.Item}-01-01#, #{e.Item}-12" +
            "-31#)";
            }

            ResumeLayout(false);
        }
    }
}
