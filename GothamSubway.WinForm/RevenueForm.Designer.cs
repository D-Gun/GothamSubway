
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedStepAreaSeriesView stackedStepAreaSeriesView4 = new DevExpress.XtraCharts.StackedStepAreaSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedStepAreaSeriesView stackedStepAreaSeriesView5 = new DevExpress.XtraCharts.StackedStepAreaSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedStepAreaSeriesView stackedStepAreaSeriesView6 = new DevExpress.XtraCharts.StackedStepAreaSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gothamMapControl = new GothamSubway.WinForm.GothamMapControl1();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.yearSelectorControl1 = new GothamSubway.WinForm.YearSelectorControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(GothamSubway.Data.Revenue);
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tblMain.Location = new System.Drawing.Point(685, 26);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.Size = new System.Drawing.Size(285, 67);
            this.tblMain.TabIndex = 4;
            // 
            // gothamMapControl
            // 
            this.gothamMapControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gothamMapControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gothamMapControl.Appearance.Options.UseBackColor = true;
            this.gothamMapControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel1.SetColumn(this.gothamMapControl, 6);
            this.gothamMapControl.Location = new System.Drawing.Point(586, 118);
            this.gothamMapControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gothamMapControl.MaximumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.MinimumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.Name = "gothamMapControl";
            this.tablePanel1.SetRow(this.gothamMapControl, 1);
            this.gothamMapControl.Size = new System.Drawing.Size(420, 374);
            this.gothamMapControl.TabIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.SetColumn(this.chartControl1, 0);
            this.tablePanel1.SetColumnSpan(this.chartControl1, 6);
            this.chartControl1.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free;
            this.chartControl1.DataSource = this.revenueBindingSource;
            xyDiagram2.AxisX.Label.TextPattern = "{A:MM\'월\'}";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(3, 64);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 1);
            series4.ArgumentDataMember = "Month";
            series4.DataSource = this.revenueBindingSource;
            series4.FilterString = "[StationId] = 1 And [SubwayCardId] = 1 And [Month] Between(#2019-01-01#, #2019-12" +
    "-31#)";
            series4.Name = "Wayne shipping";
            series4.ValueDataMembersSerializable = "Income";
            stackedStepAreaSeriesView4.Transparency = ((byte)(120));
            series4.View = stackedStepAreaSeriesView4;
            series5.ArgumentDataMember = "Month";
            series5.FilterString = "[StationId] = 1 And [SubwayCardId] = 2 And [Month] Between(#2019-01-01#, #2019-12" +
    "-31#)";
            series5.Name = "DK Transport";
            series5.ValueDataMembersSerializable = "Income";
            stackedStepAreaSeriesView5.Transparency = ((byte)(120));
            series5.View = stackedStepAreaSeriesView5;
            series6.ArgumentDataMember = "Month";
            series6.FilterString = "[StationId] = 1 And [SubwayCardId] = 3 And [Month] Between(#2019-01-01#, #2019-12" +
    "-31#)";
            series6.Name = "Gotham Credit";
            series6.ValueDataMembersSerializable = "Income";
            stackedStepAreaSeriesView6.Transparency = ((byte)(120));
            series6.View = stackedStepAreaSeriesView6;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            sideBySideBarSeriesLabel2.TextPattern = "{V}";
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chartControl1.Size = new System.Drawing.Size(576, 483);
            this.chartControl1.TabIndex = 3;
            // 
            // yearSelectorControl1
            // 
            this.yearSelectorControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel1.SetColumn(this.yearSelectorControl1, 3);
            this.tablePanel1.SetColumnSpan(this.yearSelectorControl1, 2);
            this.yearSelectorControl1.Location = new System.Drawing.Point(294, 566);
            this.yearSelectorControl1.MaximumSize = new System.Drawing.Size(108, 28);
            this.yearSelectorControl1.MinimumSize = new System.Drawing.Size(108, 28);
            this.yearSelectorControl1.Name = "yearSelectorControl1";
            this.tablePanel1.SetRow(this.yearSelectorControl1, 2);
            this.yearSelectorControl1.Size = new System.Drawing.Size(108, 28);
            this.yearSelectorControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl1, 2);
            this.tablePanel1.SetColumnSpan(this.labelControl1, 3);
            this.labelControl1.Location = new System.Drawing.Point(197, 8);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(246, 45);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "지하철 여객 수입";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AlwaysScrollActiveControlIntoView = false;
            this.tablePanel1.AutoTabOrder = false;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43F)});
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.gothamMapControl);
            this.tablePanel1.Controls.Add(this.yearSelectorControl1);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Size = new System.Drawing.Size(1022, 611);
            this.tablePanel1.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 2);
            this.labelControl2.Location = new System.Drawing.Point(197, 570);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(64, 21);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "기준년도";
            // 
            // RevenueForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 611);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.tblMain);
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedStepAreaSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private GothamMapControl1 gothamMapControl;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private YearSelectorControl yearSelectorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}