
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gothamMapControl11 = new GothamSubway.WinForm.GothamMapControl1();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(418, 47);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TransferByMonthForm";
            // 
            // gothamMapControl11
            // 
            this.gothamMapControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gothamMapControl11.Location = new System.Drawing.Point(398, 65);
            this.gothamMapControl11.MaximumSize = new System.Drawing.Size(480, 481);
            this.gothamMapControl11.MinimumSize = new System.Drawing.Size(480, 481);
            this.gothamMapControl11.Name = "gothamMapControl11";
            this.gothamMapControl11.Size = new System.Drawing.Size(480, 481);
            this.gothamMapControl11.TabIndex = 1;
            this.gothamMapControl11.ButtonClicked += new System.EventHandler<GothamSubway.WinForm.GothamMapControl1.ButtonClickedEventArgs>(this.gothamMapControl11_ButtonClicked);
            // 
            // TransferByMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 579);
            this.Controls.Add(this.gothamMapControl11);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransferByMonthForm";
            this.Text = "TransferByMonthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private GothamMapControl1 gothamMapControl11;
    }
}