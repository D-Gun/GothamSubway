
namespace GothamSubway.WinForm
{
    partial class GothamMapControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblCityHall = new System.Windows.Forms.Label();
            this.btnCityHall = new DevExpress.XtraEditors.SimpleButton();
            this.btnGothamCity = new DevExpress.XtraEditors.SimpleButton();
            this.lblGothamCity = new System.Windows.Forms.Label();
            this.btnOwlCourt = new DevExpress.XtraEditors.SimpleButton();
            this.lblOwlCourt = new System.Windows.Forms.Label();
            this.btnChungRyangLi = new DevExpress.XtraEditors.SimpleButton();
            this.lblChungRyangLi = new System.Windows.Forms.Label();
            this.btnJeGiDong = new DevExpress.XtraEditors.SimpleButton();
            this.lblJeGiDong = new System.Windows.Forms.Label();
            this.btnSinSulDong = new DevExpress.XtraEditors.SimpleButton();
            this.lblSinSulDong = new System.Windows.Forms.Label();
            this.btnDKGate = new DevExpress.XtraEditors.SimpleButton();
            this.lblDKGate = new System.Windows.Forms.Label();
            this.btnNarrows3rdst = new DevExpress.XtraEditors.SimpleButton();
            this.lblNarrows3rdst = new System.Windows.Forms.Label();
            this.btnNarrows5thst = new DevExpress.XtraEditors.SimpleButton();
            this.lblNarrows5thst = new System.Windows.Forms.Label();
            this.btnWayneEnt = new DevExpress.XtraEditors.SimpleButton();
            this.lblWayneEnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::GothamSubway.WinForm.Properties.Resources.MD_MapofGothamLine;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.MaximumSize = new System.Drawing.Size(480, 481);
            this.pictureEdit1.MinimumSize = new System.Drawing.Size(480, 481);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(480, 481);
            this.pictureEdit1.TabIndex = 0;
            // 
            // lblCityHall
            // 
            this.lblCityHall.AutoSize = true;
            this.lblCityHall.Location = new System.Drawing.Point(226, 121);
            this.lblCityHall.Name = "lblCityHall";
            this.lblCityHall.Size = new System.Drawing.Size(34, 18);
            this.lblCityHall.TabIndex = 3;
            this.lblCityHall.Text = "시청";
            // 
            // btnCityHall
            // 
            this.btnCityHall.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCityHall.Appearance.Options.UseBackColor = true;
            this.btnCityHall.Location = new System.Drawing.Point(234, 142);
            this.btnCityHall.Name = "btnCityHall";
            this.btnCityHall.Size = new System.Drawing.Size(16, 16);
            this.btnCityHall.TabIndex = 4;
            this.btnCityHall.Tag = "0";
            this.btnCityHall.Click += new System.EventHandler(this.btnCityHall_Click);
            // 
            // btnGothamCity
            // 
            this.btnGothamCity.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGothamCity.Appearance.Options.UseBackColor = true;
            this.btnGothamCity.Location = new System.Drawing.Point(289, 161);
            this.btnGothamCity.Name = "btnGothamCity";
            this.btnGothamCity.Size = new System.Drawing.Size(16, 16);
            this.btnGothamCity.TabIndex = 6;
            this.btnGothamCity.Tag = "1";
            this.btnGothamCity.Click += new System.EventHandler(this.btnGothamCity_Click);
            // 
            // lblGothamCity
            // 
            this.lblGothamCity.AutoSize = true;
            this.lblGothamCity.Location = new System.Drawing.Point(281, 140);
            this.lblGothamCity.Name = "lblGothamCity";
            this.lblGothamCity.Size = new System.Drawing.Size(60, 18);
            this.lblGothamCity.TabIndex = 5;
            this.lblGothamCity.Text = "고담씨티";
            // 
            // btnOwlCourt
            // 
            this.btnOwlCourt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOwlCourt.Appearance.Options.UseBackColor = true;
            this.btnOwlCourt.Location = new System.Drawing.Point(319, 182);
            this.btnOwlCourt.Name = "btnOwlCourt";
            this.btnOwlCourt.Size = new System.Drawing.Size(16, 16);
            this.btnOwlCourt.TabIndex = 8;
            this.btnOwlCourt.Tag = "2";
            this.btnOwlCourt.Click += new System.EventHandler(this.btnOwlCourt_Click);
            // 
            // lblOwlCourt
            // 
            this.lblOwlCourt.AutoSize = true;
            this.lblOwlCourt.Location = new System.Drawing.Point(341, 180);
            this.lblOwlCourt.Name = "lblOwlCourt";
            this.lblOwlCourt.Size = new System.Drawing.Size(86, 18);
            this.lblOwlCourt.TabIndex = 7;
            this.lblOwlCourt.Text = "올뺴미법정앞";
            // 
            // btnChungRyangLi
            // 
            this.btnChungRyangLi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChungRyangLi.Appearance.Options.UseBackColor = true;
            this.btnChungRyangLi.Location = new System.Drawing.Point(326, 213);
            this.btnChungRyangLi.Name = "btnChungRyangLi";
            this.btnChungRyangLi.Size = new System.Drawing.Size(16, 16);
            this.btnChungRyangLi.TabIndex = 10;
            this.btnChungRyangLi.Tag = "3";
            this.btnChungRyangLi.Click += new System.EventHandler(this.btnChungRyangLi_Click);
            // 
            // lblChungRyangLi
            // 
            this.lblChungRyangLi.AutoSize = true;
            this.lblChungRyangLi.Location = new System.Drawing.Point(348, 211);
            this.lblChungRyangLi.Name = "lblChungRyangLi";
            this.lblChungRyangLi.Size = new System.Drawing.Size(47, 18);
            this.lblChungRyangLi.TabIndex = 9;
            this.lblChungRyangLi.Text = "청량리";
            // 
            // btnJeGiDong
            // 
            this.btnJeGiDong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnJeGiDong.Appearance.Options.UseBackColor = true;
            this.btnJeGiDong.Location = new System.Drawing.Point(301, 310);
            this.btnJeGiDong.Name = "btnJeGiDong";
            this.btnJeGiDong.Size = new System.Drawing.Size(16, 16);
            this.btnJeGiDong.TabIndex = 12;
            this.btnJeGiDong.Tag = "4";
            this.btnJeGiDong.Click += new System.EventHandler(this.btnJeGiDong_Click);
            // 
            // lblJeGiDong
            // 
            this.lblJeGiDong.AutoSize = true;
            this.lblJeGiDong.Location = new System.Drawing.Point(291, 333);
            this.lblJeGiDong.Name = "lblJeGiDong";
            this.lblJeGiDong.Size = new System.Drawing.Size(47, 18);
            this.lblJeGiDong.TabIndex = 11;
            this.lblJeGiDong.Text = "제기동";
            // 
            // btnSinSulDong
            // 
            this.btnSinSulDong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSinSulDong.Appearance.Options.UseBackColor = true;
            this.btnSinSulDong.Location = new System.Drawing.Point(192, 339);
            this.btnSinSulDong.Name = "btnSinSulDong";
            this.btnSinSulDong.Size = new System.Drawing.Size(16, 16);
            this.btnSinSulDong.TabIndex = 14;
            this.btnSinSulDong.Tag = "5";
            this.btnSinSulDong.Click += new System.EventHandler(this.btnSinSulDong_Click);
            // 
            // lblSinSulDong
            // 
            this.lblSinSulDong.AutoSize = true;
            this.lblSinSulDong.Location = new System.Drawing.Point(182, 362);
            this.lblSinSulDong.Name = "lblSinSulDong";
            this.lblSinSulDong.Size = new System.Drawing.Size(47, 18);
            this.lblSinSulDong.TabIndex = 13;
            this.lblSinSulDong.Text = "신설동";
            // 
            // btnDKGate
            // 
            this.btnDKGate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDKGate.Appearance.Options.UseBackColor = true;
            this.btnDKGate.Location = new System.Drawing.Point(107, 310);
            this.btnDKGate.Name = "btnDKGate";
            this.btnDKGate.Size = new System.Drawing.Size(16, 16);
            this.btnDKGate.TabIndex = 16;
            this.btnDKGate.Tag = "6";
            this.btnDKGate.Click += new System.EventHandler(this.btnDKGate_Click);
            // 
            // lblDKGate
            // 
            this.lblDKGate.AutoSize = true;
            this.lblDKGate.Location = new System.Drawing.Point(57, 333);
            this.lblDKGate.Name = "lblDKGate";
            this.lblDKGate.Size = new System.Drawing.Size(66, 18);
            this.lblDKGate.TabIndex = 15;
            this.lblDKGate.Text = "DK게이트";
            // 
            // btnNarrows3rdst
            // 
            this.btnNarrows3rdst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNarrows3rdst.Appearance.Options.UseBackColor = true;
            this.btnNarrows3rdst.Location = new System.Drawing.Point(84, 265);
            this.btnNarrows3rdst.Name = "btnNarrows3rdst";
            this.btnNarrows3rdst.Size = new System.Drawing.Size(16, 16);
            this.btnNarrows3rdst.TabIndex = 18;
            this.btnNarrows3rdst.Tag = "7";
            this.btnNarrows3rdst.Click += new System.EventHandler(this.btnNarrows3rdst_Click);
            // 
            // lblNarrows3rdst
            // 
            this.lblNarrows3rdst.AutoSize = true;
            this.lblNarrows3rdst.Location = new System.Drawing.Point(6, 284);
            this.lblNarrows3rdst.Name = "lblNarrows3rdst";
            this.lblNarrows3rdst.Size = new System.Drawing.Size(81, 18);
            this.lblNarrows3rdst.TabIndex = 17;
            this.lblNarrows3rdst.Text = "내로우즈5가";
            // 
            // btnNarrows5thst
            // 
            this.btnNarrows5thst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNarrows5thst.Appearance.Options.UseBackColor = true;
            this.btnNarrows5thst.Location = new System.Drawing.Point(106, 225);
            this.btnNarrows5thst.Name = "btnNarrows5thst";
            this.btnNarrows5thst.Size = new System.Drawing.Size(16, 16);
            this.btnNarrows5thst.TabIndex = 20;
            this.btnNarrows5thst.Tag = "8";
            this.btnNarrows5thst.Click += new System.EventHandler(this.btnNarrows5thst_Click);
            // 
            // lblNarrows5thst
            // 
            this.lblNarrows5thst.AutoSize = true;
            this.lblNarrows5thst.Location = new System.Drawing.Point(19, 225);
            this.lblNarrows5thst.Name = "lblNarrows5thst";
            this.lblNarrows5thst.Size = new System.Drawing.Size(81, 18);
            this.lblNarrows5thst.TabIndex = 19;
            this.lblNarrows5thst.Text = "내로우즈3가";
            // 
            // btnWayneEnt
            // 
            this.btnWayneEnt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWayneEnt.Appearance.Options.UseBackColor = true;
            this.btnWayneEnt.Location = new System.Drawing.Point(106, 170);
            this.btnWayneEnt.Name = "btnWayneEnt";
            this.btnWayneEnt.Size = new System.Drawing.Size(16, 16);
            this.btnWayneEnt.TabIndex = 22;
            this.btnWayneEnt.Tag = "9";
            this.btnWayneEnt.Click += new System.EventHandler(this.btnWayneEnt_Click);
            // 
            // lblWayneEnt
            // 
            this.lblWayneEnt.AutoSize = true;
            this.lblWayneEnt.Location = new System.Drawing.Point(128, 170);
            this.lblWayneEnt.Name = "lblWayneEnt";
            this.lblWayneEnt.Size = new System.Drawing.Size(112, 18);
            this.lblWayneEnt.TabIndex = 21;
            this.lblWayneEnt.Text = "웨인엔터프라이즈";
            // 
            // GothamMapControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnWayneEnt);
            this.Controls.Add(this.lblWayneEnt);
            this.Controls.Add(this.btnNarrows5thst);
            this.Controls.Add(this.lblNarrows5thst);
            this.Controls.Add(this.btnNarrows3rdst);
            this.Controls.Add(this.lblNarrows3rdst);
            this.Controls.Add(this.btnDKGate);
            this.Controls.Add(this.lblDKGate);
            this.Controls.Add(this.btnSinSulDong);
            this.Controls.Add(this.lblSinSulDong);
            this.Controls.Add(this.btnJeGiDong);
            this.Controls.Add(this.lblJeGiDong);
            this.Controls.Add(this.btnChungRyangLi);
            this.Controls.Add(this.lblChungRyangLi);
            this.Controls.Add(this.btnOwlCourt);
            this.Controls.Add(this.lblOwlCourt);
            this.Controls.Add(this.btnGothamCity);
            this.Controls.Add(this.lblGothamCity);
            this.Controls.Add(this.btnCityHall);
            this.Controls.Add(this.lblCityHall);
            this.Controls.Add(this.pictureEdit1);
            this.MaximumSize = new System.Drawing.Size(480, 481);
            this.MinimumSize = new System.Drawing.Size(480, 481);
            this.Name = "GothamMapControl1";
            this.Size = new System.Drawing.Size(480, 481);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label lblCityHall;
        private DevExpress.XtraEditors.SimpleButton btnCityHall;
        private DevExpress.XtraEditors.SimpleButton btnGothamCity;
        private System.Windows.Forms.Label lblGothamCity;
        private DevExpress.XtraEditors.SimpleButton btnOwlCourt;
        private System.Windows.Forms.Label lblOwlCourt;
        private DevExpress.XtraEditors.SimpleButton btnChungRyangLi;
        private System.Windows.Forms.Label lblChungRyangLi;
        private DevExpress.XtraEditors.SimpleButton btnJeGiDong;
        private System.Windows.Forms.Label lblJeGiDong;
        private DevExpress.XtraEditors.SimpleButton btnSinSulDong;
        private System.Windows.Forms.Label lblSinSulDong;
        private DevExpress.XtraEditors.SimpleButton btnDKGate;
        private System.Windows.Forms.Label lblDKGate;
        private DevExpress.XtraEditors.SimpleButton btnNarrows3rdst;
        private System.Windows.Forms.Label lblNarrows3rdst;
        private DevExpress.XtraEditors.SimpleButton btnNarrows5thst;
        private System.Windows.Forms.Label lblNarrows5thst;
        private DevExpress.XtraEditors.SimpleButton btnWayneEnt;
        private System.Windows.Forms.Label lblWayneEnt;
    }
}
