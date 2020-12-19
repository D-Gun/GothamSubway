
namespace GothamSubway.WinForm
{
    partial class SatisfactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem1 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem2 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem3 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem4 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.CustomLegendItem customLegendItem5 = new DevExpress.XtraCharts.CustomLegendItem();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.satisfactionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.cbxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.yearSelectorControl1 = new GothamSubway.WinForm.YearSelectorControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisfactionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl1.AutoLayout = false;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.SetColumn(this.chartControl1, 0);
            this.tablePanel1.SetColumnSpan(this.chartControl1, 10);
            this.chartControl1.DataSource = this.satisfactionModelBindingSource;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            legend1.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            customLegendItem1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            customLegendItem1.Name = "매우좋음";
            customLegendItem2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            customLegendItem2.Name = "좋음";
            customLegendItem3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(183)))), ((int)(((byte)(109)))));
            customLegendItem3.Name = "보통";
            customLegendItem4.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            customLegendItem4.Name = "나쁨";
            customLegendItem5.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(134)))), ((int)(((byte)(81)))));
            customLegendItem5.Name = "매우나쁨";
            legend1.CustomItems.AddRange(new DevExpress.XtraCharts.CustomLegendItem[] {
            customLegendItem1,
            customLegendItem2,
            customLegendItem3,
            customLegendItem4,
            customLegendItem5});
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            legend1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            legend1.MarkerSize = new System.Drawing.Size(16, 16);
            legend1.Name = "Legend 1";
            this.chartControl1.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chartControl1.Location = new System.Drawing.Point(3, 61);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 1);
            this.tablePanel1.SetRowSpan(this.chartControl1, 8);
            this.chartControl1.SeriesDataMember = "SatisfactionCategory";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "SatisfactionItem";
            this.chartControl1.SeriesTemplate.ColorDataMember = "ColorData";
            this.chartControl1.SeriesTemplate.FilterString = "[SatisfactionCategory] = \'동희구\' Or [SatisfactionCategory] = \'대근구\' Or [Satisfaction" +
    "Category] = \'성윤구\'";
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            doughnutSeriesLabel1.TextPattern = "{A}:{V}%";
            this.chartControl1.SeriesTemplate.Label = doughnutSeriesLabel1;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "SatisfactionCategory";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Persent";
            doughnutSeriesView1.HoleRadiusPercent = 40;
            seriesTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            seriesTitle1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            doughnutSeriesView1.TotalLabel.TextPattern = "{S}";
            this.chartControl1.SeriesTemplate.View = doughnutSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(1162, 666);
            this.chartControl1.TabIndex = 0;
            // 
            // satisfactionModelBindingSource
            // 
            this.satisfactionModelBindingSource.DataSource = typeof(GothamSubway.Data.SatisfactionModel);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.AutoTabOrder = false;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.cbxCategory);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.yearSelectorControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.7F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.3F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.7F)});
            this.tablePanel1.Size = new System.Drawing.Size(1168, 786);
            this.tablePanel1.TabIndex = 1;
            // 
            // cbxCategory
            // 
            this.tablePanel1.SetColumn(this.cbxCategory, 1);
            this.cbxCategory.Location = new System.Drawing.Point(120, 15);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.cbxCategory, 0);
            this.cbxCategory.Size = new System.Drawing.Size(111, 24);
            this.cbxCategory.TabIndex = 10;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl1, 4);
            this.tablePanel1.SetColumnSpan(this.labelControl1, 3);
            this.labelControl1.Location = new System.Drawing.Point(470, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(345, 47);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "지하철 이용 만족도";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 4);
            this.labelControl2.Location = new System.Drawing.Point(470, 745);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 9);
            this.labelControl2.Size = new System.Drawing.Size(80, 28);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "기준년도";
            // 
            // yearSelectorControl1
            // 
            this.tablePanel1.SetColumn(this.yearSelectorControl1, 5);
            this.yearSelectorControl1.Location = new System.Drawing.Point(587, 738);
            this.yearSelectorControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.yearSelectorControl1.MaximumSize = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.MinimumSize = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.Name = "yearSelectorControl1";
            this.tablePanel1.SetRow(this.yearSelectorControl1, 9);
            this.yearSelectorControl1.Size = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.TabIndex = 1;
            // 
            // SatisfactionForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 786);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SatisfactionForm";
            this.Text = "SatisfactionForm";
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisfactionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource satisfactionModelBindingSource;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private YearSelectorControl yearSelectorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxCategory;
    }
}