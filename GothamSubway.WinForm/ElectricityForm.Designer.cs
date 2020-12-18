
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartUsage = new DevExpress.XtraCharts.ChartControl();
            this.electricityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartBill = new DevExpress.XtraCharts.ChartControl();
            this.gridUsage = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBill = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonth1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.chartUsage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartBill, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridUsage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridBill, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 786);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartUsage
            // 
            this.chartUsage.DataSource = this.electricityBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartUsage.Diagram = xyDiagram1;
            this.chartUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartUsage.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartUsage.Legend.Name = "Default Legend";
            this.chartUsage.Location = new System.Drawing.Point(3, 3);
            this.chartUsage.Name = "chartUsage";
            series1.ArgumentDataMember = "Monthdate";
            series1.FilterString = "[Month] Between(#2018-01-01#, #2018-12-31#)";
            series1.Name = "2018년";
            series1.ValueDataMembersSerializable = "Usage";
            series2.ArgumentDataMember = "Monthdate";
            series2.FilterString = "[Month] Between(#2019-01-01#, #2019-12-31#)";
            series2.Name = "2019년";
            series2.ValueDataMembersSerializable = "Usage";
            this.chartUsage.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartUsage.Size = new System.Drawing.Size(578, 387);
            this.chartUsage.TabIndex = 0;
            chartTitle1.Text = "지하철 전력 사용량";
            this.chartUsage.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // electricityBindingSource
            // 
            this.electricityBindingSource.DataSource = typeof(GothamSubway.Data.ElectricityItem);
            // 
            // chartBill
            // 
            this.chartBill.DataSource = this.electricityBindingSource;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartBill.Diagram = xyDiagram2;
            this.chartBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBill.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartBill.Legend.Name = "Default Legend";
            this.chartBill.Location = new System.Drawing.Point(587, 3);
            this.chartBill.Name = "chartBill";
            series3.ArgumentDataMember = "Monthdate";
            series3.FilterString = "[Month] Between(#2018-01-01#, #2018-12-31#)";
            series3.Name = "2018년";
            series3.ValueDataMembersSerializable = "Bill";
            series4.ArgumentDataMember = "Monthdate";
            series4.FilterString = "[Month] Between(#2019-01-01#, #2019-12-31#)";
            series4.Name = "2019년";
            series4.ValueDataMembersSerializable = "Bill";
            this.chartBill.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.chartBill.Size = new System.Drawing.Size(578, 387);
            this.chartBill.TabIndex = 1;
            chartTitle2.Text = "지하철 전기 요금";
            this.chartBill.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // gridUsage
            // 
            this.gridUsage.DataSource = this.electricityBindingSource;
            this.gridUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsage.Location = new System.Drawing.Point(3, 396);
            this.gridUsage.MainView = this.gridView1;
            this.gridUsage.Name = "gridUsage";
            this.gridUsage.Size = new System.Drawing.Size(578, 387);
            this.gridUsage.TabIndex = 2;
            this.gridUsage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMonth,
            this.colUsage});
            this.gridView1.GridControl = this.gridUsage;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMonth
            // 
            this.colMonth.FieldName = "Month";
            this.colMonth.MinWidth = 25;
            this.colMonth.Name = "colMonth";
            this.colMonth.OptionsColumn.AllowEdit = false;
            this.colMonth.OptionsColumn.AllowMove = false;
            this.colMonth.Visible = true;
            this.colMonth.VisibleIndex = 0;
            this.colMonth.Width = 94;
            // 
            // colUsage
            // 
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
            // gridBill
            // 
            this.gridBill.DataSource = this.electricityBindingSource;
            this.gridBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBill.Location = new System.Drawing.Point(587, 396);
            this.gridBill.MainView = this.gridView2;
            this.gridBill.Name = "gridBill";
            this.gridBill.Size = new System.Drawing.Size(578, 387);
            this.gridBill.TabIndex = 3;
            this.gridBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMonth1,
            this.colBill});
            this.gridView2.GridControl = this.gridBill;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMonth1
            // 
            this.colMonth1.FieldName = "Month";
            this.colMonth1.MinWidth = 25;
            this.colMonth1.Name = "colMonth1";
            this.colMonth1.OptionsColumn.AllowEdit = false;
            this.colMonth1.OptionsColumn.AllowMove = false;
            this.colMonth1.Visible = true;
            this.colMonth1.VisibleIndex = 0;
            this.colMonth1.Width = 94;
            // 
            // colBill
            // 
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colUsage;
        private DevExpress.XtraGrid.GridControl gridBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth1;
        private DevExpress.XtraGrid.Columns.GridColumn colBill;
    }
}