using DevExpress.XtraEditors;
using GothamSubway.Data;
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
    public partial class TransferByMonthForm : XtraForm
    {
        public TransferByMonthForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) // 폼 로드 시gridview생성 이벤트
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            initStation();
        }

        private void initStation()
        {
            stringYear = 2019;
            gothamMapControl.ButtonClicked +=
                new EventHandler<GothamMapControl1.ButtonClickedEventArgs>(gothamMapControl_ButtonClicked);//맵컨트롤 이벤트 핸들러 subscribe
            gothamMapControl.InitButton();//유저컨트롤 버튼 강제 발동 이벤트

            yearSelectorControl1.SelectComboBox +=
                new EventHandler<YearSelectorControl.SelectComboBoxEventArgs>(yearSelectorControl1_SelectComboBox); // 콤보박스 이벤트 핸들러 subscribe
            yearSelectorControl1.Initialize(Dao.FootTraffic.GetAllYears());

            //var dailyTransfer = Dao.FootTraffic.GetMonthlyFootTraffics(Convert.ToInt32(stringYear), stationNumber);
            //footTrafficTotalModelBindingSource.DataSource = dailyTransfer;
            var monthlyTransfer = Dao.FootTraffic.GetMonthlyFootTraffics(Convert.ToInt32(stringYear), stationNumber);
            footTrafficMonthlyTotalModelBindingSource.DataSource = monthlyTransfer;
        }

        public int stringYear { get; set; }//콤보박스 기준년도 프로퍼티 선언
        public int stationNumber { get; set; }//지하철역 버튼 태그 프로퍼티 선언


        private void gothamMapControl_ButtonClicked(object sender, GothamMapControl1.ButtonClickedEventArgs e)
        {
            stationNumber = e.StationNumber;

            dataBinding();
        }

        private void yearSelectorControl1_SelectComboBox(object sender, YearSelectorControl.SelectComboBoxEventArgs e)
        {
            stringYear = e.Item;

            dataBinding();
        }
        private void dataBinding()
        {
            //var dailyTransfer = Dao.FootTraffic.GetMonthlyFootTraffics(Convert.ToInt32(stringYear), stationNumber);
            //footTrafficTotalModelBindingSource.DataSource = dailyTransfer;
            var monthlyTransfer = Dao.FootTraffic.GetMonthlyFootTraffics(Convert.ToInt32(stringYear), stationNumber);
            footTrafficMonthlyTotalModelBindingSource.DataSource = monthlyTransfer;
        }
    }
}