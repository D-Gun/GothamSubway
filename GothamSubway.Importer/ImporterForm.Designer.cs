
namespace GothamSubway.Importer
{
    partial class ImporterForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.rbtFootTraffic = new System.Windows.Forms.RadioButton();
            this.rbtSatisfaction = new System.Windows.Forms.RadioButton();
            this.rbtElectricity = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bgwLoader = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.bgwInsert = new System.ComponentModel.BackgroundWorker();
            this.lblProgress2 = new System.Windows.Forms.Label();
            this.rbtSatisfaction2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Location = new System.Drawing.Point(13, 13);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.RowTemplate.Height = 23;
            this.dgvViewer.Size = new System.Drawing.Size(632, 425);
            this.dgvViewer.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(689, 386);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(99, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(689, 415);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(99, 23);
            this.btnSaveDB.TabIndex = 2;
            this.btnSaveDB.Text = "Save Database";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // rbtFootTraffic
            // 
            this.rbtFootTraffic.AutoSize = true;
            this.rbtFootTraffic.Location = new System.Drawing.Point(651, 12);
            this.rbtFootTraffic.Name = "rbtFootTraffic";
            this.rbtFootTraffic.Size = new System.Drawing.Size(137, 16);
            this.rbtFootTraffic.TabIndex = 3;
            this.rbtFootTraffic.TabStop = true;
            this.rbtFootTraffic.Tag = "1";
            this.rbtFootTraffic.Text = "FootTraffic+Revenue";
            this.rbtFootTraffic.UseVisualStyleBackColor = true;
            this.rbtFootTraffic.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtSatisfaction
            // 
            this.rbtSatisfaction.AutoSize = true;
            this.rbtSatisfaction.Location = new System.Drawing.Point(651, 34);
            this.rbtSatisfaction.Name = "rbtSatisfaction";
            this.rbtSatisfaction.Size = new System.Drawing.Size(88, 16);
            this.rbtSatisfaction.TabIndex = 4;
            this.rbtSatisfaction.TabStop = true;
            this.rbtSatisfaction.Tag = "2";
            this.rbtSatisfaction.Text = "Satisfaction";
            this.rbtSatisfaction.UseVisualStyleBackColor = true;
            this.rbtSatisfaction.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtElectricity
            // 
            this.rbtElectricity.AutoSize = true;
            this.rbtElectricity.Location = new System.Drawing.Point(651, 56);
            this.rbtElectricity.Name = "rbtElectricity";
            this.rbtElectricity.Size = new System.Drawing.Size(78, 16);
            this.rbtElectricity.TabIndex = 5;
            this.rbtElectricity.TabStop = true;
            this.rbtElectricity.Tag = "3";
            this.rbtElectricity.Text = "Electricity";
            this.rbtElectricity.UseVisualStyleBackColor = true;
            this.rbtElectricity.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bgwLoader
            // 
            this.bgwLoader.WorkerReportsProgress = true;
            this.bgwLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoader_DoWork);
            this.bgwLoader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwLoader_ProgressChanged);
            this.bgwLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoader_RunWorkerCompleted);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(651, 110);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(38, 12);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "label1";
            // 
            // bgwInsert
            // 
            this.bgwInsert.WorkerReportsProgress = true;
            this.bgwInsert.WorkerSupportsCancellation = true;
            this.bgwInsert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInsert_DoWork);
            this.bgwInsert.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwInsert_ProgressChanged);
            this.bgwInsert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInsert_RunWorkerCompleted);
            // 
            // lblProgress2
            // 
            this.lblProgress2.AutoSize = true;
            this.lblProgress2.Location = new System.Drawing.Point(651, 133);
            this.lblProgress2.Name = "lblProgress2";
            this.lblProgress2.Size = new System.Drawing.Size(38, 12);
            this.lblProgress2.TabIndex = 7;
            this.lblProgress2.Text = "label1";
            // 
            // rbtSatisfaction2
            // 
            this.rbtSatisfaction2.AutoSize = true;
            this.rbtSatisfaction2.Location = new System.Drawing.Point(651, 79);
            this.rbtSatisfaction2.Name = "rbtSatisfaction2";
            this.rbtSatisfaction2.Size = new System.Drawing.Size(94, 16);
            this.rbtSatisfaction2.TabIndex = 8;
            this.rbtSatisfaction2.TabStop = true;
            this.rbtSatisfaction2.Tag = "4";
            this.rbtSatisfaction2.Text = "Satisfaction2";
            this.rbtSatisfaction2.UseVisualStyleBackColor = true;
            this.rbtSatisfaction2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // ImporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtSatisfaction2);
            this.Controls.Add(this.lblProgress2);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.rbtElectricity);
            this.Controls.Add(this.rbtSatisfaction);
            this.Controls.Add(this.rbtFootTraffic);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dgvViewer);
            this.Name = "ImporterForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.RadioButton rbtFootTraffic;
        private System.Windows.Forms.RadioButton rbtSatisfaction;
        private System.Windows.Forms.RadioButton rbtElectricity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker bgwLoader;
        private System.Windows.Forms.Label lblProgress;
        private System.ComponentModel.BackgroundWorker bgwInsert;
        private System.Windows.Forms.Label lblProgress2;
        private System.Windows.Forms.RadioButton rbtSatisfaction2;
    }
}

