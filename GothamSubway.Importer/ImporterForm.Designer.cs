
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.rbtFootTraffic = new System.Windows.Forms.RadioButton();
            this.rbtSatisfaction = new System.Windows.Forms.RadioButton();
            this.rbtElectricity = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(632, 425);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // rbtFootTraffic
            // 
            this.rbtFootTraffic.AutoSize = true;
            this.rbtFootTraffic.Location = new System.Drawing.Point(651, 12);
            this.rbtFootTraffic.Name = "rbtFootTraffic";
            this.rbtFootTraffic.Size = new System.Drawing.Size(137, 16);
            this.rbtFootTraffic.TabIndex = 3;
            this.rbtFootTraffic.TabStop = true;
            this.rbtFootTraffic.Text = "FootTraffic+Revenue";
            this.rbtFootTraffic.UseVisualStyleBackColor = true;
            // 
            // rbtSatisfaction
            // 
            this.rbtSatisfaction.AutoSize = true;
            this.rbtSatisfaction.Location = new System.Drawing.Point(651, 34);
            this.rbtSatisfaction.Name = "rbtSatisfaction";
            this.rbtSatisfaction.Size = new System.Drawing.Size(88, 16);
            this.rbtSatisfaction.TabIndex = 4;
            this.rbtSatisfaction.TabStop = true;
            this.rbtSatisfaction.Text = "Satisfaction";
            this.rbtSatisfaction.UseVisualStyleBackColor = true;
            // 
            // rbtElectricity
            // 
            this.rbtElectricity.AutoSize = true;
            this.rbtElectricity.Location = new System.Drawing.Point(651, 56);
            this.rbtElectricity.Name = "rbtElectricity";
            this.rbtElectricity.Size = new System.Drawing.Size(78, 16);
            this.rbtElectricity.TabIndex = 5;
            this.rbtElectricity.TabStop = true;
            this.rbtElectricity.Text = "Electricity";
            this.rbtElectricity.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtElectricity);
            this.Controls.Add(this.rbtSatisfaction);
            this.Controls.Add(this.rbtFootTraffic);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ImporterForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.RadioButton rbtFootTraffic;
        private System.Windows.Forms.RadioButton rbtSatisfaction;
        private System.Windows.Forms.RadioButton rbtElectricity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

