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

        private ButtonClickedEventArgs OnButtonClicked(int stationNunmber)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs(stationNunmber);
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
            public int StationNumber { get; set; }

            public ButtonClickedEventArgs()
            {
            }

            public ButtonClickedEventArgs(int stationNumber)
            {
                StationNumber = stationNumber;
            }
        }


        #endregion
        private void OccoredEvent(object sender)
        {
            SimpleButton btn = sender as SimpleButton;
            InitializeButtonColor();
            btn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ButtonClickedEventArgs args = new ButtonClickedEventArgs();
            
            args.StationNumber = Convert.ToInt32(btn.Tag);
            /* 버튼 태그 - 역이름 주석
            * 1 고담씨티
            * 2 시청
            * 3 웨인엔터프라이즈
            * 4 내로우즈 3가
            * 5 내로우즈 5가
            * 6 DK게이트
            * 7 신설동
            * 8 제기동
            * 9 청량리
            * 10 올뺴미법정앞
            */
            OnButtonClicked(args.StationNumber);
        }

        public void InitButton()
        {
            btnGothamCity.PerformClick(); // OccoredEvent(btnCityHall) 과 같음
        }

        private void InitializeButtonColor()
        {
            foreach(var control in Controls)
            {
                if(control.GetType() == btnCityHall.GetType())
                    ((SimpleButton)control).Appearance.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
        }


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
