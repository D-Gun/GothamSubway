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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            var electricityItems = Dao.Electricity.GetElectricity();
            
            electricityBindingSource.DataSource = electricityItems;
        }
    }
}
