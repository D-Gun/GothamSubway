
namespace GothamSubway.WinForm
{
    partial class ElectricityForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY2 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView3 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView4 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartUsage = new DevExpress.XtraCharts.ChartControl();
            this.electricityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartBill = new DevExpress.XtraCharts.ChartControl();
            this.gridUsage = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsageMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsageYoY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBill = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonthBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillYoYRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yearSelectorControl1 = new GothamSubway.WinForm.YearSelectorControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartUsage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartBill, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridUsage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridBill, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.yearSelectorControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 786);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartUsage
            // 
            this.chartUsage.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartUsage.DataSource = this.electricityBindingSource;
            xyDiagram1.AxisX.Label.TextPattern = "{A}월";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Text = "전력 사용량(kWh)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.Title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondaryAxisY1.Title.Text = "증감율(%)";
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.WholeRange.Auto = false;
            secondaryAxisY1.WholeRange.MaxValueSerializable = "10";
            secondaryAxisY1.WholeRange.MinValueSerializable = "-10";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.chartUsage.Diagram = xyDiagram1;
            this.chartUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartUsage.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartUsage.Legend.Name = "Default Legend";
            this.chartUsage.Location = new System.Drawing.Point(3, 50);
            this.chartUsage.Name = "chartUsage";
            series1.ArgumentDataMember = "Monthdate";
            series1.FilterString = "[Month] Between(#2018-01-01#, #2018-12-31#)";
            series1.Name = "series1";
            series1.ValueDataMembersSerializable = "Usage";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            series1.View = sideBySideBarSeriesView1;
            series2.ArgumentDataMember = "Monthdate";
            series2.FilterString = "[Month] Between(#2019-01-01#, #2019-12-31#)";
            series2.Name = "series2";
            series2.ValueDataMembersSerializable = "Usage";
            sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.View = sideBySideBarSeriesView2;
            series3.ArgumentDataMember = "Monthdate";
            series3.FilterString = "[Month] Between(#2019-01-01#, #2019-12-31#)";
            series3.LegendName = "Default Legend";
            series3.Name = "증감율";
            series3.ValueDataMembersSerializable = "UsageYoYRate";
            lineSeriesView1.AxisYName = "Secondary AxisY 1";
            lineSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Diamond;
            lineSeriesView1.LineMarkerOptions.Size = 7;
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.View = lineSeriesView1;
            this.chartUsage.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartUsage.Size = new System.Drawing.Size(578, 363);
            this.chartUsage.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "지하철 전력 사용량";
            chartTitle1.TextColor = System.Drawing.Color.Black;
            this.chartUsage.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // electricityBindingSource
            // 
            this.electricityBindingSource.DataSource = typeof(GothamSubway.Data.ElectricityItem);
            // 
            // chartBill
            // 
            this.chartBill.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartBill.DataSource = this.electricityBindingSource;
            xyDiagram2.AxisX.Label.TextPattern = "{A}월";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram2.AxisY.Title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram2.AxisY.Title.Text = "전기 요금(원)";
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            secondaryAxisY2.AxisID = 0;
            secondaryAxisY2.Name = "Secondary AxisY 1";
            secondaryAxisY2.Title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondaryAxisY2.Title.Text = "증감율(%)";
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisY2.VisibleInPanesSerializable = "-1";
            secondaryAxisY2.WholeRange.Auto = false;
            secondaryAxisY2.WholeRange.MaxValueSerializable = "10";
            secondaryAxisY2.WholeRange.MinValueSerializable = "-10";
            xyDiagram2.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY2});
            this.chartBill.Diagram = xyDiagram2;
            this.chartBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBill.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartBill.Legend.Name = "Default Legend";
            this.chartBill.Location = new System.Drawing.Point(587, 50);
            this.chartBill.Name = "chartBill";
            series4.ArgumentDataMember = "Monthdate";
            series4.FilterString = "[Month] Between(#2018-01-01#, #2018-12-31#)";
            series4.Name = "series1";
            series4.ValueDataMembersSerializable = "Bill";
            sideBySideBarSeriesView3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            series4.View = sideBySideBarSeriesView3;
            series5.ArgumentDataMember = "Monthdate";
            series5.FilterString = "[Month] Between(#2019-01-01#, #2019-12-31#)";
            series5.Name = "series2";
            series5.ValueDataMembersSerializable = "Bill";
            sideBySideBarSeriesView4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series5.View = sideBySideBarSeriesView4;
            series6.ArgumentDataMember = "Monthdate";
            series6.FilterString = "[Month] Between(#2019-01-01#, #2019-12-31#)";
            series6.Name = "증감율";
            series6.ValueDataMembersSerializable = "BillYoYRate";
            lineSeriesView2.AxisYName = "Secondary AxisY 1";
            lineSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Diamond;
            lineSeriesView2.LineMarkerOptions.Size = 7;
            lineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series6.View = lineSeriesView2;
            this.chartBill.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            this.chartBill.Size = new System.Drawing.Size(578, 363);
            this.chartBill.TabIndex = 1;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle2.Text = "지하철 전기 요금";
            chartTitle2.TextColor = System.Drawing.Color.Black;
            this.chartBill.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // gridUsage
            // 
            this.gridUsage.DataSource = this.electricityBindingSource;
            this.gridUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridUsage.Location = new System.Drawing.Point(3, 419);
            this.gridUsage.MainView = this.gridView1;
            this.gridUsage.Name = "gridUsage";
            this.gridUsage.Size = new System.Drawing.Size(578, 364);
            this.gridUsage.TabIndex = 2;
            this.gridUsage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsageMonth,
            this.colUsage,
            this.colUsageYoY});
            this.gridView1.GridControl = this.gridUsage;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "전력 사용량 세부내역";
            // 
            // colUsageMonth
            // 
            this.colUsageMonth.Caption = "일자";
            this.colUsageMonth.DisplayFormat.FormatString = "yyyy-MM";
            this.colUsageMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUsageMonth.FieldName = "Month";
            this.colUsageMonth.MinWidth = 25;
            this.colUsageMonth.Name = "colUsageMonth";
            this.colUsageMonth.OptionsColumn.AllowEdit = false;
            this.colUsageMonth.OptionsColumn.AllowMove = false;
            this.colUsageMonth.Visible = true;
            this.colUsageMonth.VisibleIndex = 0;
            this.colUsageMonth.Width = 94;
            // 
            // colUsage
            // 
            this.colUsage.Caption = "사용량(kWh)";
            this.colUsage.DisplayFormat.FormatString = "#,#";
            this.colUsage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUsage.FieldName = "Usage";
            this.colUsage.MinWidth = 25;
            this.colUsage.Name = "colUsage";
            this.colUsage.OptionsColumn.AllowEdit = false;
            this.colUsage.OptionsColumn.AllowMove = false;
            this.colUsage.Visible = true;
            this.colUsage.VisibleIndex = 1;
            this.colUsage.Width = 94;
            // 
            // colUsageYoY
            // 
            this.colUsageYoY.Caption = "전년대비증감율";
            this.colUsageYoY.DisplayFormat.FormatString = "0.00\'%\'";
            this.colUsageYoY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUsageYoY.FieldName = "UsageYoYRate";
            this.colUsageYoY.MinWidth = 25;
            this.colUsageYoY.Name = "colUsageYoY";
            this.colUsageYoY.OptionsColumn.AllowEdit = false;
            this.colUsageYoY.OptionsColumn.AllowMove = false;
            this.colUsageYoY.Visible = true;
            this.colUsageYoY.VisibleIndex = 2;
            this.colUsageYoY.Width = 94;
            // 
            // gridBill
            // 
            this.gridBill.DataSource = this.electricityBindingSource;
            this.gridBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBill.Location = new System.Drawing.Point(587, 419);
            this.gridBill.MainView = this.gridView2;
            this.gridBill.Name = "gridBill";
            this.gridBill.Size = new System.Drawing.Size(578, 364);
            this.gridBill.TabIndex = 3;
            this.gridBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMonthBill,
            this.colBill,
            this.colBillYoYRate});
            this.gridView2.GridControl = this.gridBill;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "전기 요금 세부내역";
            // 
            // colMonthBill
            // 
            this.colMonthBill.Caption = "일자";
            this.colMonthBill.DisplayFormat.FormatString = "yyyy-MM";
            this.colMonthBill.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMonthBill.FieldName = "Month";
            this.colMonthBill.MinWidth = 25;
            this.colMonthBill.Name = "colMonthBill";
            this.colMonthBill.OptionsColumn.AllowEdit = false;
            this.colMonthBill.OptionsColumn.AllowMove = false;
            this.colMonthBill.Visible = true;
            this.colMonthBill.VisibleIndex = 0;
            this.colMonthBill.Width = 94;
            // 
            // colBill
            // 
            this.colBill.Caption = "사용요금(원)";
            this.colBill.DisplayFormat.FormatString = "#,#";
            this.colBill.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBill.FieldName = "Bill";
            this.colBill.MinWidth = 25;
            this.colBill.Name = "colBill";
            this.colBill.OptionsColumn.AllowEdit = false;
            this.colBill.OptionsColumn.AllowMove = false;
            this.colBill.Visible = true;
            this.colBill.VisibleIndex = 1;
            this.colBill.Width = 94;
            // 
            // colBillYoYRate
            // 
            this.colBillYoYRate.Caption = "전년대비증감율";
            this.colBillYoYRate.DisplayFormat.FormatString = "0.00\'%\'";
            this.colBillYoYRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBillYoYRate.FieldName = "BillYoYRate";
            this.colBillYoYRate.MinWidth = 25;
            this.colBillYoYRate.Name = "colBillYoYRate";
            this.colBillYoYRate.OptionsColumn.AllowEdit = false;
            this.colBillYoYRate.OptionsColumn.AllowMove = false;
            this.colBillYoYRate.Visible = true;
            this.colBillYoYRate.VisibleIndex = 2;
            this.colBillYoYRate.Width = 94;
            // 
            // yearSelectorControl1
            // 
            this.yearSelectorControl1.Location = new System.Drawing.Point(3, 5);
            this.yearSelectorControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.yearSelectorControl1.MaximumSize = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.MinimumSize = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.Name = "yearSelectorControl1";
            this.yearSelectorControl1.Size = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.TabIndex = 4;
            // 
            // ElectricityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 786);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ElectricityForm";
            this.Text = "ElectricityForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl chartUsage;
        private DevExpress.XtraCharts.ChartControl chartBill;
        private System.Windows.Forms.BindingSource electricityBindingSource;
        private DevExpress.XtraGrid.GridControl gridUsage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthBill;
        private DevExpress.XtraGrid.Columns.GridColumn colBill;
        private DevExpress.XtraGrid.Columns.GridColumn colUsageMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colUsage;
        private DevExpress.XtraGrid.Columns.GridColumn colUsageYoY;
        private DevExpress.XtraGrid.Columns.GridColumn colBillYoYRate;
        private YearSelectorControl yearSelectorControl1;
    }
}