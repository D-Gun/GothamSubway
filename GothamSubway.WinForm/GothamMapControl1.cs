using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GothamSubway.WinForm
{
    public partial class GothamMapControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        public GothamMapControl1()
        {
            InitializeComponent();            
        }

        #region ButtonClicked event things for C# 3.0
        public event EventHandler<ButtonClickedEventArgs> ButtonClicked;

        protected virtual void OnButtonClicked(ButtonClickedEventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }

        private ButtonClickedEventArgs OnButtonClicked(string stationName)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs(stationName);
            OnButtonClicked(args);

            return args;
        }

        private ButtonClickedEventArgs OnButtonClickedForOut()
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs();
            OnButtonClicked(args);

            return args;
        }

        public class ButtonClickedEventArgs : EventArgs
        {
            public string StationName { get; set; }

            public ButtonClickedEventArgs()
            {
            }

            public ButtonClickedEventArgs(string stationName)
            {
                StationName = stationName;
            }
        }
        #endregion
        private void OccoredEvent(object sender)
        {
            SimpleButton btn = sender as SimpleButton;
            InitializeButtonColor();
            btn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ButtonClickedEventArgs args = new ButtonClickedEventArgs();
            args.StationName = btn.Tag.ToString();
            OnButtonClicked(args.StationName);
        }

        private void InitializeButtonColor()
        {
            foreach(var control in Controls)
            {
                if(control.GetType() == btnCityHall.GetType())
                    ((SimpleButton)control).Appearance.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
        }

        /* 역이름 주석
         * 0 시청
         * 1 고담씨티
         * 2 올뺴미법정앞
         * 3 청량리
         * 4 제기동
         * 5 신설동
         * 6 DK게이트
         * 7 내로우즈 5가
         * 8 내로우즈 3가
         * 9 웨인엔터프라이즈
         */


        private void btnCityHall_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnGothamCity_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnOwlCourt_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnChungRyangLi_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnJeGiDong_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnSinSulDong_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnDKGate_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnNarrows3rdst_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnNarrows5thst_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }

        private void btnWayneEnt_Click(object sender, EventArgs e)
        {
            OccoredEvent(sender);
        }
    }
}
