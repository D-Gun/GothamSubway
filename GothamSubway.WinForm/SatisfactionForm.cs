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
using System.Data.Entity;
using GothamSubway.Data;

namespace GothamSubway.WinForm
{
    public partial class SatisfactionForm : XtraForm
    {
        public SatisfactionForm()
        {
            InitializeComponent();
            SelectedYear = 2019;
        }

        List<SatisfactionModel> satisfactionModels;

        public int SelectedSatisfactionCategoryId { get; set; }
        public int SelectedYear { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            satisfactionModels = Dao.Satisfaction.GetModels();
            satisfactionModelBindingSource.DataSource = satisfactionModels;

            List<string> items = Dao.SatisfactionCategory.GetUpperCategory().Select(x => x.Item).ToList(); 
            cbxCategory.Properties.Items.AddRange(items);
            cbxCategory.SelectedIndex = 0;

            yearSelectorControl1.SelectComboBox += YearSelectorControl1_SelectComboBox; ;
            yearSelectorControl1.Initialize(Dao.Revenue.GetAllYears());
        }

        private void Resume()
        {
            List<SatisfactionModel> models = satisfactionModels.
                FindAll(x => (x.SatisfactionCategoryId / 100) == SelectedSatisfactionCategoryId)
                .OrderBy(x => x.SatisfactionCategoryId).ToList();

            string filterString = "";

            for(int i =0; i < models.Count; i++)
            {
                filterString += $" [SatisfactionCategory] = '{models[i].SatisfactionCategory}' ";
                if (i != models.Count - 1)
                    filterString += "Or";
            }

            chartControl1.SeriesTemplate.FilterString = filterString;
            ResumeLayout(false);
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSatisfactionCategoryId = cbxCategory.SelectedIndex + 1;
            Resume();
        }

        private void YearSelectorControl1_SelectComboBox(object sender, YearSelectorControl.SelectComboBoxEventArgs e)
        {
            SelectedYear = e.Item;
            Resume();
        }
    }
}
