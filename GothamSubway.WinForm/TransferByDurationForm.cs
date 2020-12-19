using DevExpress.XtraEditors;
using GothamSubway.Data;
using System;

namespace GothamSubway.WinForm
{
    public partial class TransferByDurationForm : XtraForm
    {
        public TransferByDurationForm()
        {
            InitializeComponent();
        }

        public DateTime SelectedStartDate { get; set; }
        public DateTime SelectedEndDate { get; set; }
        public DateTime MinimumDate { get; set; }
        public DateTime MaximumDate { get; set; }
        public int SelectedStation { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SelectedStartDate = new DateTime(2019, 1, 1);
            SelectedEndDate = new DateTime(2019, 1, 31);

            MinimumDate = Dao.FootTraffic.GetMinimumDate();
            MaximumDate = Dao.FootTraffic.GetMaximumDate();

            footTrafficDurationSumModelBindingSource.DataSource = Dao.FootTraffic.GetDurationSumModel();

            gothamMapControl.ButtonClicked += GothamMapControl_ButtonClicked;
            gothamMapControl.InitButton();
        }

        private void Resume()
        {
            footTrafficDurationAverageModelBindingSource.DataSource = Dao.FootTraffic.GetDurationAverageModel(SelectedStartDate, SelectedEndDate);

            chartControl1.Series[0].FilterString = $"[StationId] = {SelectedStation} And [TransferId] = 1";
            chartControl1.Series[1].FilterString = $"[StationId] = {SelectedStation} And [TransferId] = 2";

            chartControl2.Series[0].FilterString = $"[StationId] = {SelectedStation} And [TransferId] = 1 And [Date] Between(#{SelectedStartDate.ToShortDateString()}#, #{SelectedEndDate.ToShortDateString()}#)";
            chartControl2.Series[1].FilterString = $"[StationId] = {SelectedStation} And [TransferId] = 2 And [Date] Between(#{SelectedStartDate.ToShortDateString()}#, #{SelectedEndDate.ToShortDateString()}#)";

            ResumeLayout(false);
        }

        private void GothamMapControl_ButtonClicked(object sender, GothamMapControl1.ButtonClickedEventArgs e)
        {
            SelectedStation = e.StationNumber;
            Resume();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (CheckDate() == false)
                return;
            SelectedStartDate = dtoStartDate.DateTimeOffset.Date;
            SelectedEndDate = dtoEndDate.DateTimeOffset.Date;
            Resume();
        }

        private bool CheckDate()
        {
            if (dtoStartDate.DateTimeOffset > dtoEndDate.DateTimeOffset)
            {
                Utility.Mbox("알림", "날짜 입력이 잘못되었습니다. 종료 날짜는 시작 날짜보다 빠를 수 없습니다.");
                dtoStartDate.DateTimeOffset = SelectedStartDate;
                dtoEndDate.DateTimeOffset = SelectedEndDate;
                return false;
            }
            if (dtoStartDate.DateTimeOffset.DateTime < MinimumDate)
            {
                Utility.Mbox("알림", $"입력 가능한 최소 날짜는 {MinimumDate.ToShortDateString()}입니다");
                dtoStartDate.DateTimeOffset = SelectedStartDate;
                return false;
            }
            if (dtoEndDate.DateTimeOffset.DateTime > MaximumDate)
            {
                Utility.Mbox("알림", $"입력 가능한 최대 날짜는 {MaximumDate.ToShortDateString()}입니다");
                dtoEndDate.DateTimeOffset = SelectedEndDate;
                return false;
            }

            return true;
        }
    }
}
