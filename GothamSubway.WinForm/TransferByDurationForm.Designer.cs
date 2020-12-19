
namespace GothamSubway.WinForm
{
    partial class TransferByDurationForm
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
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.footTrafficDurationAverageModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.footTrafficDurationSumModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtoEndDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.dtoStartDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gothamMapControl = new GothamSubway.WinForm.GothamMapControl1();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficDurationAverageModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficDurationSumModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtoEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoStartDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.53425F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.46575F));
            this.tblMain.Controls.Add(this.gothamMapControl, 1, 1);
            this.tblMain.Controls.Add(this.chartControl1, 0, 1);
            this.tblMain.Controls.Add(this.chartControl2, 0, 2);
            this.tblMain.Controls.Add(this.panelControl1, 1, 0);
            this.tblMain.Controls.Add(this.labelControl2, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.ForeColor = System.Drawing.Color.Transparent;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblMain.Size = new System.Drawing.Size(1168, 786);
            this.tblMain.TabIndex = 4;
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl1.DataSource = this.footTrafficDurationAverageModelBindingSource;
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Title.Text = "시간대";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Text = "인원수(명)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(3, 82);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Aspect";
            series1.ArgumentDataMember = "Time";
            series1.CrosshairLabelPattern = "{S} : {V:0.00}";
            series1.FilterString = "[StationId] = 1 And [TransferId] = 1";
            series1.Name = "승차";
            series1.ValueDataMembersSerializable = "Average";
            sideBySideBarSeriesView1.Transparency = ((byte)(80));
            series1.View = sideBySideBarSeriesView1;
            series2.ArgumentDataMember = "Time";
            series2.CrosshairLabelPattern = "{S} : {V:0.00}";
            series2.FilterString = "[StationId] = 1 And [TransferId] = 2";
            series2.Name = "하차";
            series2.ValueDataMembersSerializable = "Average";
            sideBySideBarSeriesView2.Transparency = ((byte)(80));
            series2.View = sideBySideBarSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.Size = new System.Drawing.Size(666, 267);
            this.chartControl1.TabIndex = 3;
            // 
            // footTrafficDurationAverageModelBindingSource
            // 
            this.footTrafficDurationAverageModelBindingSource.DataSource = typeof(GothamSubway.Data.FootTrafficDurationAverageModel);
            // 
            // chartControl2
            // 
            this.chartControl2.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl2.DataSource = this.footTrafficDurationSumModelBindingSource;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram2.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram2.AxisY.Title.Text = "인원수(명)";
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(3, 357);
            this.chartControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PaletteName = "Aspect";
            series3.ArgumentDataMember = "Date";
            series3.FilterString = "[StationId] = 1 And [TransferId] = 1";
            series3.Name = "승차";
            series3.ValueDataMembersSerializable = "Sum";
            series3.View = splineSeriesView1;
            series4.ArgumentDataMember = "Date";
            series4.FilterString = "[StationId] = 1 And [TransferId] = 2";
            series4.Name = "하차";
            series4.ValueDataMembersSerializable = "Sum";
            series4.View = splineSeriesView2;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.chartControl2.Size = new System.Drawing.Size(666, 425);
            this.chartControl2.TabIndex = 4;
            // 
            // footTrafficDurationSumModelBindingSource
            // 
            this.footTrafficDurationSumModelBindingSource.DataSource = typeof(GothamSubway.Data.FootTrafficDurationSumModel);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.dtoEndDate);
            this.panelControl1.Controls.Add(this.dtoStartDate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(675, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(490, 70);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Location = new System.Drawing.Point(191, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "~";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(331, 23);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 30);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "검색";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtoEndDate
            // 
            this.dtoEndDate.EditValue = new System.DateTime(2019, 1, 31, 20, 44, 32, 0);
            this.dtoEndDate.Location = new System.Drawing.Point(210, 24);
            this.dtoEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtoEndDate.Name = "dtoEndDate";
            this.dtoEndDate.Properties.BeepOnError = false;
            this.dtoEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtoEndDate.Properties.DisplayFormat.FormatString = "d";
            this.dtoEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoEndDate.Properties.MaskSettings.Set("mask", "d");
            this.dtoEndDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtoEndDate.Size = new System.Drawing.Size(114, 24);
            this.dtoEndDate.TabIndex = 1;
            this.dtoEndDate.EditValueChanged += new System.EventHandler(this.dtoEndDate_EditValueChanged);
            // 
            // dtoStartDate
            // 
            this.dtoStartDate.EditValue = new System.DateTime(2019, 1, 1, 20, 44, 9, 0);
            this.dtoStartDate.Location = new System.Drawing.Point(72, 24);
            this.dtoStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtoStartDate.Name = "dtoStartDate";
            this.dtoStartDate.Properties.BeepOnError = false;
            this.dtoStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtoStartDate.Properties.DisplayFormat.FormatString = "d";
            this.dtoStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtoStartDate.Properties.MaskSettings.Set("mask", "d");
            this.dtoStartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtoStartDate.Size = new System.Drawing.Size(114, 24);
            this.dtoStartDate.TabIndex = 0;
            this.dtoStartDate.EditValueChanged += new System.EventHandler(this.dtoStartDate_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(666, 70);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "기간별 승하차 인원";
            // 
            // gothamMapControl
            // 
            this.gothamMapControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gothamMapControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gothamMapControl.Appearance.Options.UseBackColor = true;
            this.gothamMapControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gothamMapControl.Location = new System.Drawing.Point(680, 191);
            this.gothamMapControl.MaximumSize = new System.Drawing.Size(480, 481);
            this.gothamMapControl.MinimumSize = new System.Drawing.Size(480, 481);
            this.gothamMapControl.Name = "gothamMapControl";
            this.tblMain.SetRowSpan(this.gothamMapControl, 2);
            this.gothamMapControl.Size = new System.Drawing.Size(480, 481);
            this.gothamMapControl.TabIndex = 2;
            // 
            // TransferByDurationForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 786);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransferByDurationForm";
            this.Text = "TransferByDurationForm";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficDurationAverageModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficDurationSumModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtoEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoStartDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private GothamMapControl1 gothamMapControl;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource footTrafficDurationAverageModelBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.BindingSource footTrafficDurationSumModelBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtoStartDate;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtoEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}