
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gothamMapControl = new GothamSubway.WinForm.GothamMapControl1();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tblMain.Controls.Add(this.gothamMapControl, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1022, 611);
            this.tblMain.TabIndex = 4;
            // 
            // gothamMapControl
            // 
            this.gothamMapControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gothamMapControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gothamMapControl.Appearance.Options.UseBackColor = true;
            this.gothamMapControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gothamMapControl.Location = new System.Drawing.Point(592, 118);
            this.gothamMapControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gothamMapControl.MaximumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.MinimumSize = new System.Drawing.Size(420, 374);
            this.gothamMapControl.Name = "gothamMapControl";
            this.gothamMapControl.Size = new System.Drawing.Size(420, 374);
            this.gothamMapControl.TabIndex = 2;
            // 
            // TransferByMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 611);
            this.Controls.Add(this.tblMain);
            this.Name = "TransferByMonthForm";
            this.Text = "TransferByMonthForm";
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private GothamMapControl1 gothamMapControl;
    }
}