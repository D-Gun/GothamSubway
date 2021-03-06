﻿
namespace GothamSubway.Importer
{
    partial class ImportForm
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
            this.rbtSatisfaction2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.psbWorking = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewer
            // 
            this.dgvViewer.AllowUserToAddRows = false;
            this.dgvViewer.AllowUserToDeleteRows = false;
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Location = new System.Drawing.Point(13, 13);
            this.dgvViewer.Name = "dgvViewer";
            this.dgvViewer.ReadOnly = true;
            this.dgvViewer.RowTemplate.Height = 23;
            this.dgvViewer.Size = new System.Drawing.Size(632, 396);
            this.dgvViewer.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(651, 173);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(99, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "파일 읽기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(651, 202);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(99, 23);
            this.btnSaveDB.TabIndex = 2;
            this.btnSaveDB.Text = "서버에 저장";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // rbtFootTraffic
            // 
            this.rbtFootTraffic.AutoSize = true;
            this.rbtFootTraffic.Location = new System.Drawing.Point(651, 12);
            this.rbtFootTraffic.Name = "rbtFootTraffic";
            this.rbtFootTraffic.Size = new System.Drawing.Size(59, 16);
            this.rbtFootTraffic.TabIndex = 3;
            this.rbtFootTraffic.TabStop = true;
            this.rbtFootTraffic.Tag = "1";
            this.rbtFootTraffic.Text = "승하차";
            this.rbtFootTraffic.UseVisualStyleBackColor = true;
            this.rbtFootTraffic.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtSatisfaction
            // 
            this.rbtSatisfaction.AutoSize = true;
            this.rbtSatisfaction.Location = new System.Drawing.Point(651, 34);
            this.rbtSatisfaction.Name = "rbtSatisfaction";
            this.rbtSatisfaction.Size = new System.Drawing.Size(83, 16);
            this.rbtSatisfaction.TabIndex = 4;
            this.rbtSatisfaction.TabStop = true;
            this.rbtSatisfaction.Tag = "2";
            this.rbtSatisfaction.Text = "이용만족도";
            this.rbtSatisfaction.UseVisualStyleBackColor = true;
            this.rbtSatisfaction.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtElectricity
            // 
            this.rbtElectricity.AutoSize = true;
            this.rbtElectricity.Location = new System.Drawing.Point(651, 56);
            this.rbtElectricity.Name = "rbtElectricity";
            this.rbtElectricity.Size = new System.Drawing.Size(83, 16);
            this.rbtElectricity.TabIndex = 5;
            this.rbtElectricity.TabStop = true;
            this.rbtElectricity.Tag = "3";
            this.rbtElectricity.Text = "전력사용량";
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
            this.lblProgress.Location = new System.Drawing.Point(6, 17);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 12);
            this.lblProgress.TabIndex = 6;
            // 
            // bgwInsert
            // 
            this.bgwInsert.WorkerReportsProgress = true;
            this.bgwInsert.WorkerSupportsCancellation = true;
            this.bgwInsert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInsert_DoWork);
            this.bgwInsert.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwInsert_ProgressChanged);
            this.bgwInsert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInsert_RunWorkerCompleted);
            // 
            // rbtSatisfaction2
            // 
            this.rbtSatisfaction2.AutoSize = true;
            this.rbtSatisfaction2.Location = new System.Drawing.Point(651, 79);
            this.rbtSatisfaction2.Name = "rbtSatisfaction2";
            this.rbtSatisfaction2.Size = new System.Drawing.Size(71, 16);
            this.rbtSatisfaction2.TabIndex = 8;
            this.rbtSatisfaction2.TabStop = true;
            this.rbtSatisfaction2.Tag = "4";
            this.rbtSatisfaction2.Text = "여객수입";
            this.rbtSatisfaction2.UseVisualStyleBackColor = true;
            this.rbtSatisfaction2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "종류에 적합하지 않은 형태의 엑셀 파일을 사용하시어 진행할 경우, 데이터의 손상이 생길 수 있음을 유념해 주시기 바랍니다.";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(651, 231);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(99, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "작업 중지";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // psbWorking
            // 
            this.psbWorking.Location = new System.Drawing.Point(8, 32);
            this.psbWorking.Name = "psbWorking";
            this.psbWorking.Size = new System.Drawing.Size(123, 23);
            this.psbWorking.TabIndex = 11;
            this.psbWorking.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProgress);
            this.groupBox1.Controls.Add(this.psbWorking);
            this.groupBox1.Location = new System.Drawing.Point(654, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "진행률";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtSatisfaction2);
            this.Controls.Add(this.rbtElectricity);
            this.Controls.Add(this.rbtSatisfaction);
            this.Controls.Add(this.rbtFootTraffic);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dgvViewer);
            this.Name = "ImportForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbtSatisfaction2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ProgressBar psbWorking;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

