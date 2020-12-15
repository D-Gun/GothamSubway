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
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildForm(Form form)
        {
            if (form == null)
                return;

            var childForm = MdiChildren.FirstOrDefault(x => x.GetType() == form.GetType());

            if (childForm == null)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
                childForm.Focus();
        }

        private void itmTransferByMonth_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowChildForm(null/* new TransferWithMonthForm() */);
        }

        private void itmTransferByDuration_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowChildForm(null/* new TransferWithDurationForm() */);
        }

        private void itmRevenue_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowChildForm(null/* new RevenueForm() */);
        }

        private void itmSatisfaction_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowChildForm(null/* new SatisfactionForm() */);
        }

        private void itmElectricity_ItemClick(object sender, TileItemEventArgs e)
        {
            ShowChildForm(null/* new ElectricityForm() */);
        }
    }
}