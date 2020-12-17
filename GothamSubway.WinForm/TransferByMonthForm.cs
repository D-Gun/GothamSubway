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

        protected override void OnLoad(EventArgs e) // gridview생성 이벤트
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

        }

        public string stringYear { get; set; }//콤보박스 기준년도 프로퍼티 선언
        public int stationNumber { get; set; }//지하철역 버튼 태그 프로퍼티 선언


        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbxYear.SelectedItem != "기준년도")
                stringYear = (string)cbxYear.SelectedItem;

            var monthlyTransfer = Dao.FootTraffic.GetMonthlyFootTraffics(Convert.ToInt32(stringYear),stationNumber);
            footTrafficTotalModelBindingSource.DataSource = monthlyTransfer;

        }

        private void gothamMapControl_ButtonClicked(object sender, GothamMapControl1.ButtonClickedEventArgs e)
        {
            stationNumber = e.StationNumber;

            var monthlyTransfer = Dao.FootTraffic.GetMonthlyFootTraffics(Convert.ToInt32(stringYear), stationNumber);
            footTrafficTotalModelBindingSource.DataSource = monthlyTransfer;

            MessageBox.Show($"{e.StationNumber}");
        }
    }
}
