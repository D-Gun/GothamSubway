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
            form.MdiParent = this;
            form.Show();
        }

        private Form FindChildForm(string text)
        {
            foreach (var form in MdiChildren)
            {
                if (form.Text == text)
                    return form;
            }

            return null;
        }

        private void itmTransferWithMonth_ItemClick(object sender, TileItemEventArgs e)
        {
            //Form form = FindChildForm("Form1");

            //if (form == null)
            //    ShowChildForm(new Form1());
            //else
            //    form.Activate();
        }

        private void itmTransferWithDuration_ItemClick(object sender, TileItemEventArgs e)
        {
            //Form form = FindChildForm("Form2");

            //if (form == null)
            //    ShowChildForm(new Form2());
            //else
            //    form.Activate();
        }
    }

    public class MyTabbedMdiManager : DevExpress.XtraTabbedMdi.XtraTabbedMdiManager, DevExpress.XtraTab.IXtraTabProperties
    {
        public MyTabbedMdiManager(IContainer container) : base(container) {}
        DevExpress.Utils.DefaultBoolean DevExpress.XtraTab.IXtraTabProperties.ShowTabHeader { get { return DevExpress.Utils.DefaultBoolean.False; } }
    }
}