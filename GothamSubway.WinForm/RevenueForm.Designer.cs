
namespace GothamSubway.WinForm
{
    partial class RevenueForm
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
            DevExpress.XtraCharts.StackedStepAreaSeriesView stackedStepAreaSeriesView1 = new DevExpress.XtraCharts.StackedStepAreaSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedStepAreaSeriesView stackedStepAreaSeriesView2 = new DevExpress.XtraCharts.StackedStepAreaSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedStepAreaSeriesView stackedStepAreaSeriesView3 = new DevExpress.XtraCharts.StackedStepAreaSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gothamMapControl = new GothamSubway.WinForm.GothamMapControl1();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.yearSelectorControl1 = new GothamSubway.WinForm.YearSelectorControl();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(GothamSubway.Data.Revenue);
            // 
            // tblMain
            // 
            this.tblMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tblMain.Controls.Add(this.gothamMapControl, 1, 0);
            this.tblMain.Controls.Add(this.chartControl1, 0, 0);
            this.tblMain.Location = new System.Drawing.Point(106, 12);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(904, 531);
            this.tblMain.TabIndex = 4;
            // 
            // gothamMapControl
            // 
            this.gothamMapControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gothamMapControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gothamMapControl.Appearance.Options.UseBackColor = true;
            this.gothamMapControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gothamMapControl.Location = new System.Drawing.Point(518, 78);
            this.gothamMapControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gothamMapControl.MaximumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.MinimumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.Name = "gothamMapControl";
            this.gothamMapControl.Size = new System.Drawing.Size(420, 374);
            this.gothamMapControl.TabIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free;
            this.chartControl1.DataSource = this.revenueBindingSource;
            xyDiagram1.AxisX.Label.TextPattern = "{A:MM\'월\'}";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(3, 3);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "Month";
            series1.DataSource = this.revenueBindingSource;
            series1.FilterString = "[StationId] = 1 And [SubwayCardId] = 1 And [Month] Between(#2019-01-01#, #2019-12" +
    "-31#)";
            series1.Name = "Wayne shipping";
            series1.ValueDataMembersSerializable = "Income";
            stackedStepAreaSeriesView1.Transparency = ((byte)(120));
            series1.View = stackedStepAreaSeriesView1;
            series2.ArgumentDataMember = "Month";
            series2.FilterString = "[StationId] = 1 And [SubwayCardId] = 2 And [Month] Between(#2019-01-01#, #2019-12" +
    "-31#)";
            series2.Name = "DK Transport";
            series2.ValueDataMembersSerializable = "Income";
            stackedStepAreaSeriesView2.Transparency = ((byte)(120));
            series2.View = stackedStepAreaSeriesView2;
            series3.ArgumentDataMember = "Month";
            series3.FilterString = "[StationId] = 1 And [SubwayCardId] = 3 And [Month] Between(#2019-01-01#, #2019-12" +
    "-31#)";
            series3.Name = "Gotham Credit";
            series3.ValueDataMembersSerializable = "Income";
            stackedStepAreaSeriesView3.Transparency = ((byte)(120));
            series3.View = stackedStepAreaSeriesView3;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            sideBySideBarSeriesLabel1.TextPattern = "{V}";
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.Size = new System.Drawing.Size(467, 375);
            this.chartControl1.TabIndex = 3;
            // 
            // yearSelectorControl1
            // 
            this.yearSelectorControl1.Location = new System.Drawing.Point(12, 12);
            this.yearSelectorControl1.Name = "yearSelectorControl1";
            this.yearSelectorControl1.Size = new System.Drawing.Size(108, 28);
            this.yearSelectorControl1.TabIndex = 5;
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 611);
            this.Controls.Add(this.yearSelectorControl1);
            this.Controls.Add(this.tblMain);
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private GothamMapControl1 gothamMapControl;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private YearSelectorControl yearSelectorControl1;
    }
}