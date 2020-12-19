
namespace GothamSubway.WinForm
{
    partial class TransferByMonthForm
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
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView2 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView3 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.footTrafficMonthlyTotalModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gothamMapControl = new GothamSubway.WinForm.GothamMapControl1();
            this.yearSelectorControl1 = new GothamSubway.WinForm.YearSelectorControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.기준년도 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficMonthlyTotalModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.기준년도)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chartControl1.DataSource = this.footTrafficMonthlyTotalModelBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(12, 68);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "date";
            series1.FilterString = "[transferId] = 1";
            series1.Name = "승차";
            series1.ValueDataMembersSerializable = "monthlytotal";
            series1.View = areaSeriesView1;
            series2.ArgumentDataMember = "date";
            series2.FilterString = "[transferId] = 2";
            series2.Name = "하차";
            series2.ValueDataMembersSerializable = "monthlytotal";
            series2.View = areaSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            areaSeriesView3.Transparency = ((byte)(0));
            this.chartControl1.SeriesTemplate.View = areaSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(567, 446);
            this.chartControl1.TabIndex = 2;
            // 
            // footTrafficMonthlyTotalModelBindingSource
            // 
            this.footTrafficMonthlyTotalModelBindingSource.DataSource = typeof(GothamSubway.Data.FootTrafficMonthlyTotalModel);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gothamMapControl);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Controls.Add(this.yearSelectorControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 335, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1022, 611);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.Root.AppearanceGroup.Options.UseBackColor = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.기준년도});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 57D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 43D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 10D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 80D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 15D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(1022, 611);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chartControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(571, 450);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gothamMapControl
            // 
            this.gothamMapControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gothamMapControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gothamMapControl.Appearance.Options.UseBackColor = true;
            this.gothamMapControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gothamMapControl.Location = new System.Drawing.Point(583, 68);
            this.gothamMapControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gothamMapControl.MaximumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.MinimumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.Name = "gothamMapControl";
            this.gothamMapControl.Size = new System.Drawing.Size(420, 374);
            this.gothamMapControl.TabIndex = 4;
            // 
            // yearSelectorControl1
            // 
            this.yearSelectorControl1.Location = new System.Drawing.Point(12, 518);
            this.yearSelectorControl1.MaximumSize = new System.Drawing.Size(108, 33);
            this.yearSelectorControl1.MinimumSize = new System.Drawing.Size(108, 33);
            this.yearSelectorControl1.Name = "yearSelectorControl1";
            this.yearSelectorControl1.Size = new System.Drawing.Size(108, 33);
            this.yearSelectorControl1.TabIndex = 1;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gothamMapControl;
            this.layoutControlItem3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem3.Location = new System.Drawing.Point(571, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(431, 450);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // 기준년도
            // 
            this.기준년도.Control = this.yearSelectorControl1;
            this.기준년도.Location = new System.Drawing.Point(0, 506);
            this.기준년도.Name = "기준년도";
            this.기준년도.OptionsTableLayoutItem.RowIndex = 2;
            this.기준년도.Size = new System.Drawing.Size(571, 85);
            this.기준년도.TextSize = new System.Drawing.Size(0, 0);
            this.기준년도.TextVisible = false;
            // 
            // TransferByMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 611);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TransferByMonthForm";
            this.Text = "TransferByMonthForm";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficMonthlyTotalModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.기준년도)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyTransferTotalDataGridViewTextBoxColumn;
        private YearSelectorControl yearSelectorControl1;
        private System.Windows.Forms.BindingSource footTrafficMonthlyTotalModelBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyTransferTotal;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private GothamMapControl1 gothamMapControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem 기준년도;
    }
}