using DevExpress.XtraEditors;
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
    public partial class TransferByMonthForm : XtraForm
    {
        public TransferByMonthForm()
        {
            InitializeComponent();
        }

        private void gothamMapControl11_ButtonClicked(object sender, GothamMapControl1.ButtonClickedEventArgs e)
        {
            MessageBox.Show($"{e.StationName}");
        }
    }
}
