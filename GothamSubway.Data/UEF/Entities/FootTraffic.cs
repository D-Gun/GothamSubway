using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamSubway.Data
{
    public partial class FootTraffic
    {
    }

    public class FootTrafficDurationAverageModel
    {
        public int StationId { get; set; }
        public int TransferId { get; set; }
        public string Time { get; set; }
        public double Average { get; set; }
    }

    public class FootTrafficDurationSumModel
    {
        public DateTime Date { get; set; }
        public int StationId { get; set; }
        public int TransferId { get; set; }
        public int Sum { get; set; }
    }

    public class FootTrafficTotalModel
    {
        public int dailyTransferTotal { get; set; }
        public int monthlyTransferTotal { get; set; }
        public DateTime date { get; set; }
        public int transferId { get; set; }
        public int stationId { get; set; }
        public int beforeSix { get; set; }
        public int sixToSeven { get; set; }
        public int sevenToEight { get; set; }
        public int eightToNine { get; set; }
        public int nineToTen { get; set; }
        public int tenToEleven { get; set; }
        public int elevenToTwelve { get; set; }
        public int twelveToThirteen { get; set; }
        public int thirteenToFourteen { get; set; }
        public int fourteenToFifteen { get; set; }
        public int fifteenToSixteen { get; set; }
        public int sixteenToSeventeen { get; set; }
        public int seventeenToEighteen { get; set; }
        public int eighteenToNineteen { get; set; }
        public int nineteenToTwenty { get; set; }
        public int twentyToTwentyOne { get; set; }
        public int twentyOneToTwentyTwo { get; set; }
        public int twentyTwoToTwentyThree { get; set; }
        public int twentyThreeToTwentyFour { get; set; }
        public int afterTwentyFour { get; set; }
    }

    public class FootTrafficMonthlyTotalModel
    {
        public DateTime date { get; set; }
        public int stationId { get; set; }
        public int transferId { get; set; }
        public int monthlytotal { get; set; }
    }
}
