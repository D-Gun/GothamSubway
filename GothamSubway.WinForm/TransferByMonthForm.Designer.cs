
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gothamMapControl = new GothamSubway.WinForm.GothamMapControl1();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dailyTransferTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyTransferTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeSixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixToSevenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sevenToEightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eightToNineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nineToTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenToElevenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevenToTwelveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twelveToThirteenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirteenToFourteenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fourteenToFifteenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fifteenToSixteenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixteenToSeventeenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seventeenToEighteenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eighteenToNineteenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twentyToTwentyOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterTwentyFourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footTrafficTotalModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearSelectorControl1 = new GothamSubway.WinForm.YearSelectorControl();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficTotalModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tblMain.Controls.Add(this.gothamMapControl, 1, 0);
            this.tblMain.Controls.Add(this.panelControl1, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1168, 786);
            this.tblMain.TabIndex = 4;
            // 
            // gothamMapControl
            // 
            this.gothamMapControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gothamMapControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gothamMapControl.Appearance.Options.UseBackColor = true;
            this.gothamMapControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gothamMapControl.Location = new System.Drawing.Point(676, 152);
            this.gothamMapControl.MaximumSize = new System.Drawing.Size(480, 481);
            this.gothamMapControl.MinimumSize = new System.Drawing.Size(480, 481);
            this.gothamMapControl.Name = "gothamMapControl";
            this.gothamMapControl.Size = new System.Drawing.Size(480, 481);
            this.gothamMapControl.TabIndex = 2;
            
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.yearSelectorControl1);
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(659, 780);
            this.panelControl1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dailyTransferTotalDataGridViewTextBoxColumn,
            this.monthlyTransferTotalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.transferIdDataGridViewTextBoxColumn,
            this.stationIdDataGridViewTextBoxColumn,
            this.beforeSixDataGridViewTextBoxColumn,
            this.sixToSevenDataGridViewTextBoxColumn,
            this.sevenToEightDataGridViewTextBoxColumn,
            this.eightToNineDataGridViewTextBoxColumn,
            this.nineToTenDataGridViewTextBoxColumn,
            this.tenToElevenDataGridViewTextBoxColumn,
            this.elevenToTwelveDataGridViewTextBoxColumn,
            this.twelveToThirteenDataGridViewTextBoxColumn,
            this.thirteenToFourteenDataGridViewTextBoxColumn,
            this.fourteenToFifteenDataGridViewTextBoxColumn,
            this.fifteenToSixteenDataGridViewTextBoxColumn,
            this.sixteenToSeventeenDataGridViewTextBoxColumn,
            this.seventeenToEighteenDataGridViewTextBoxColumn,
            this.eighteenToNineteenDataGridViewTextBoxColumn,
            this.twentyToTwentyOneDataGridViewTextBoxColumn,
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn,
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn,
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn,
            this.afterTwentyFourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.footTrafficTotalModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(662, 724);
            this.dataGridView1.TabIndex = 0;
            // 
            // dailyTransferTotalDataGridViewTextBoxColumn
            // 
            this.dailyTransferTotalDataGridViewTextBoxColumn.DataPropertyName = "dailyTransferTotal";
            this.dailyTransferTotalDataGridViewTextBoxColumn.HeaderText = "dailyTransferTotal";
            this.dailyTransferTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dailyTransferTotalDataGridViewTextBoxColumn.Name = "dailyTransferTotalDataGridViewTextBoxColumn";
            this.dailyTransferTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthlyTransferTotalDataGridViewTextBoxColumn
            // 
            this.monthlyTransferTotalDataGridViewTextBoxColumn.DataPropertyName = "monthlyTransferTotal";
            this.monthlyTransferTotalDataGridViewTextBoxColumn.HeaderText = "monthlyTransferTotal";
            this.monthlyTransferTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthlyTransferTotalDataGridViewTextBoxColumn.Name = "monthlyTransferTotalDataGridViewTextBoxColumn";
            this.monthlyTransferTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transferIdDataGridViewTextBoxColumn
            // 
            this.transferIdDataGridViewTextBoxColumn.DataPropertyName = "transferId";
            this.transferIdDataGridViewTextBoxColumn.HeaderText = "transferId";
            this.transferIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferIdDataGridViewTextBoxColumn.Name = "transferIdDataGridViewTextBoxColumn";
            this.transferIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stationIdDataGridViewTextBoxColumn
            // 
            this.stationIdDataGridViewTextBoxColumn.DataPropertyName = "stationId";
            this.stationIdDataGridViewTextBoxColumn.HeaderText = "stationId";
            this.stationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stationIdDataGridViewTextBoxColumn.Name = "stationIdDataGridViewTextBoxColumn";
            this.stationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // beforeSixDataGridViewTextBoxColumn
            // 
            this.beforeSixDataGridViewTextBoxColumn.DataPropertyName = "beforeSix";
            this.beforeSixDataGridViewTextBoxColumn.HeaderText = "beforeSix";
            this.beforeSixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beforeSixDataGridViewTextBoxColumn.Name = "beforeSixDataGridViewTextBoxColumn";
            this.beforeSixDataGridViewTextBoxColumn.Width = 125;
            // 
            // sixToSevenDataGridViewTextBoxColumn
            // 
            this.sixToSevenDataGridViewTextBoxColumn.DataPropertyName = "sixToSeven";
            this.sixToSevenDataGridViewTextBoxColumn.HeaderText = "sixToSeven";
            this.sixToSevenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sixToSevenDataGridViewTextBoxColumn.Name = "sixToSevenDataGridViewTextBoxColumn";
            this.sixToSevenDataGridViewTextBoxColumn.Width = 125;
            // 
            // sevenToEightDataGridViewTextBoxColumn
            // 
            this.sevenToEightDataGridViewTextBoxColumn.DataPropertyName = "sevenToEight";
            this.sevenToEightDataGridViewTextBoxColumn.HeaderText = "sevenToEight";
            this.sevenToEightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sevenToEightDataGridViewTextBoxColumn.Name = "sevenToEightDataGridViewTextBoxColumn";
            this.sevenToEightDataGridViewTextBoxColumn.Width = 125;
            // 
            // eightToNineDataGridViewTextBoxColumn
            // 
            this.eightToNineDataGridViewTextBoxColumn.DataPropertyName = "eightToNine";
            this.eightToNineDataGridViewTextBoxColumn.HeaderText = "eightToNine";
            this.eightToNineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eightToNineDataGridViewTextBoxColumn.Name = "eightToNineDataGridViewTextBoxColumn";
            this.eightToNineDataGridViewTextBoxColumn.Width = 125;
            // 
            // nineToTenDataGridViewTextBoxColumn
            // 
            this.nineToTenDataGridViewTextBoxColumn.DataPropertyName = "nineToTen";
            this.nineToTenDataGridViewTextBoxColumn.HeaderText = "nineToTen";
            this.nineToTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nineToTenDataGridViewTextBoxColumn.Name = "nineToTenDataGridViewTextBoxColumn";
            this.nineToTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenToElevenDataGridViewTextBoxColumn
            // 
            this.tenToElevenDataGridViewTextBoxColumn.DataPropertyName = "tenToEleven";
            this.tenToElevenDataGridViewTextBoxColumn.HeaderText = "tenToEleven";
            this.tenToElevenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenToElevenDataGridViewTextBoxColumn.Name = "tenToElevenDataGridViewTextBoxColumn";
            this.tenToElevenDataGridViewTextBoxColumn.Width = 125;
            // 
            // elevenToTwelveDataGridViewTextBoxColumn
            // 
            this.elevenToTwelveDataGridViewTextBoxColumn.DataPropertyName = "elevenToTwelve";
            this.elevenToTwelveDataGridViewTextBoxColumn.HeaderText = "elevenToTwelve";
            this.elevenToTwelveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elevenToTwelveDataGridViewTextBoxColumn.Name = "elevenToTwelveDataGridViewTextBoxColumn";
            this.elevenToTwelveDataGridViewTextBoxColumn.Width = 125;
            // 
            // twelveToThirteenDataGridViewTextBoxColumn
            // 
            this.twelveToThirteenDataGridViewTextBoxColumn.DataPropertyName = "twelveToThirteen";
            this.twelveToThirteenDataGridViewTextBoxColumn.HeaderText = "twelveToThirteen";
            this.twelveToThirteenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twelveToThirteenDataGridViewTextBoxColumn.Name = "twelveToThirteenDataGridViewTextBoxColumn";
            this.twelveToThirteenDataGridViewTextBoxColumn.Width = 125;
            // 
            // thirteenToFourteenDataGridViewTextBoxColumn
            // 
            this.thirteenToFourteenDataGridViewTextBoxColumn.DataPropertyName = "thirteenToFourteen";
            this.thirteenToFourteenDataGridViewTextBoxColumn.HeaderText = "thirteenToFourteen";
            this.thirteenToFourteenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thirteenToFourteenDataGridViewTextBoxColumn.Name = "thirteenToFourteenDataGridViewTextBoxColumn";
            this.thirteenToFourteenDataGridViewTextBoxColumn.Width = 125;
            // 
            // fourteenToFifteenDataGridViewTextBoxColumn
            // 
            this.fourteenToFifteenDataGridViewTextBoxColumn.DataPropertyName = "fourteenToFifteen";
            this.fourteenToFifteenDataGridViewTextBoxColumn.HeaderText = "fourteenToFifteen";
            this.fourteenToFifteenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fourteenToFifteenDataGridViewTextBoxColumn.Name = "fourteenToFifteenDataGridViewTextBoxColumn";
            this.fourteenToFifteenDataGridViewTextBoxColumn.Width = 125;
            // 
            // fifteenToSixteenDataGridViewTextBoxColumn
            // 
            this.fifteenToSixteenDataGridViewTextBoxColumn.DataPropertyName = "fifteenToSixteen";
            this.fifteenToSixteenDataGridViewTextBoxColumn.HeaderText = "fifteenToSixteen";
            this.fifteenToSixteenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fifteenToSixteenDataGridViewTextBoxColumn.Name = "fifteenToSixteenDataGridViewTextBoxColumn";
            this.fifteenToSixteenDataGridViewTextBoxColumn.Width = 125;
            // 
            // sixteenToSeventeenDataGridViewTextBoxColumn
            // 
            this.sixteenToSeventeenDataGridViewTextBoxColumn.DataPropertyName = "sixteenToSeventeen";
            this.sixteenToSeventeenDataGridViewTextBoxColumn.HeaderText = "sixteenToSeventeen";
            this.sixteenToSeventeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sixteenToSeventeenDataGridViewTextBoxColumn.Name = "sixteenToSeventeenDataGridViewTextBoxColumn";
            this.sixteenToSeventeenDataGridViewTextBoxColumn.Width = 125;
            // 
            // seventeenToEighteenDataGridViewTextBoxColumn
            // 
            this.seventeenToEighteenDataGridViewTextBoxColumn.DataPropertyName = "seventeenToEighteen";
            this.seventeenToEighteenDataGridViewTextBoxColumn.HeaderText = "seventeenToEighteen";
            this.seventeenToEighteenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seventeenToEighteenDataGridViewTextBoxColumn.Name = "seventeenToEighteenDataGridViewTextBoxColumn";
            this.seventeenToEighteenDataGridViewTextBoxColumn.Width = 125;
            // 
            // eighteenToNineteenDataGridViewTextBoxColumn
            // 
            this.eighteenToNineteenDataGridViewTextBoxColumn.DataPropertyName = "eighteenToNineteen";
            this.eighteenToNineteenDataGridViewTextBoxColumn.HeaderText = "eighteenToNineteen";
            this.eighteenToNineteenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eighteenToNineteenDataGridViewTextBoxColumn.Name = "eighteenToNineteenDataGridViewTextBoxColumn";
            this.eighteenToNineteenDataGridViewTextBoxColumn.Width = 125;
            // 
            // twentyToTwentyOneDataGridViewTextBoxColumn
            // 
            this.twentyToTwentyOneDataGridViewTextBoxColumn.DataPropertyName = "twentyToTwentyOne";
            this.twentyToTwentyOneDataGridViewTextBoxColumn.HeaderText = "twentyToTwentyOne";
            this.twentyToTwentyOneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twentyToTwentyOneDataGridViewTextBoxColumn.Name = "twentyToTwentyOneDataGridViewTextBoxColumn";
            this.twentyToTwentyOneDataGridViewTextBoxColumn.Width = 125;
            // 
            // twentyOneToTwentyTwoDataGridViewTextBoxColumn
            // 
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn.DataPropertyName = "twentyOneToTwentyTwo";
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn.HeaderText = "twentyOneToTwentyTwo";
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn.Name = "twentyOneToTwentyTwoDataGridViewTextBoxColumn";
            this.twentyOneToTwentyTwoDataGridViewTextBoxColumn.Width = 125;
            // 
            // twentyTwoToTwentyThreeDataGridViewTextBoxColumn
            // 
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn.DataPropertyName = "twentyTwoToTwentyThree";
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn.HeaderText = "twentyTwoToTwentyThree";
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn.Name = "twentyTwoToTwentyThreeDataGridViewTextBoxColumn";
            this.twentyTwoToTwentyThreeDataGridViewTextBoxColumn.Width = 125;
            // 
            // twentyThreeToTwentyFourDataGridViewTextBoxColumn
            // 
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn.DataPropertyName = "twentyThreeToTwentyFour";
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn.HeaderText = "twentyThreeToTwentyFour";
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn.Name = "twentyThreeToTwentyFourDataGridViewTextBoxColumn";
            this.twentyThreeToTwentyFourDataGridViewTextBoxColumn.Width = 125;
            // 
            // afterTwentyFourDataGridViewTextBoxColumn
            // 
            this.afterTwentyFourDataGridViewTextBoxColumn.DataPropertyName = "afterTwentyFour";
            this.afterTwentyFourDataGridViewTextBoxColumn.HeaderText = "afterTwentyFour";
            this.afterTwentyFourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.afterTwentyFourDataGridViewTextBoxColumn.Name = "afterTwentyFourDataGridViewTextBoxColumn";
            this.afterTwentyFourDataGridViewTextBoxColumn.Width = 125;
            // 
            // footTrafficTotalModelBindingSource
            // 
            this.footTrafficTotalModelBindingSource.DataSource = typeof(GothamSubway.Data.FootTrafficTotalModel);
            // 
            // yearSelectorControl1
            // 
            this.yearSelectorControl1.Location = new System.Drawing.Point(9, 7);
            this.yearSelectorControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.yearSelectorControl1.MaximumSize = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.MinimumSize = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.Name = "yearSelectorControl1";
            this.yearSelectorControl1.Size = new System.Drawing.Size(123, 42);
            this.yearSelectorControl1.TabIndex = 1;
           
            // 
            // TransferByMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 786);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransferByMonthForm";
            this.Text = "TransferByMonthForm";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footTrafficTotalModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private GothamMapControl1 gothamMapControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyTransferTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyTransferTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeSixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixToSevenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevenToEightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eightToNineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nineToTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenToElevenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elevenToTwelveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twelveToThirteenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirteenToFourteenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fourteenToFifteenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fifteenToSixteenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixteenToSeventeenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seventeenToEighteenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eighteenToNineteenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twentyToTwentyOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twentyOneToTwentyTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twentyTwoToTwentyThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twentyThreeToTwentyFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterTwentyFourDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource footTrafficTotalModelBindingSource;
        private YearSelectorControl yearSelectorControl1;
    }
}