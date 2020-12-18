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
    public partial class YearSelectorControl : UserControl
    {
        public YearSelectorControl()
        {
            InitializeComponent();            
        }

        public void Initialize(List<int> list)
        {
            list.Sort();
            comboBoxEdit1.Properties.Items.AddRange(list);
            if (comboBoxEdit1.SelectedIndex == list.Count - 1)
                OnSelectComboBox((int)comboBoxEdit1.SelectedItem);
            comboBoxEdit1.SelectedIndex = list.Count - 1;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectComboBox((int)comboBoxEdit1.SelectedItem);
        }

        #region SelectComboBox event things for C# 3.0
        public event EventHandler<SelectComboBoxEventArgs> SelectComboBox;

        protected virtual void OnSelectComboBox(SelectComboBoxEventArgs e)
        {
            if (SelectComboBox != null)
                SelectComboBox(this, e);
        }

        private SelectComboBoxEventArgs OnSelectComboBox(int item)
        {
            SelectComboBoxEventArgs args = new SelectComboBoxEventArgs(item);
            OnSelectComboBox(args);

            return args;
        }

        private SelectComboBoxEventArgs OnSelectComboBoxForOut()
        {
            SelectComboBoxEventArgs args = new SelectComboBoxEventArgs();
            OnSelectComboBox(args);

            return args;
        }

        public class SelectComboBoxEventArgs : EventArgs
        {
            public int Item { get; set; }

            public SelectComboBoxEventArgs()
            {
            }

            public SelectComboBoxEventArgs(int item)
            {
                Item = item;
            }
        }
        #endregion
    }
}
