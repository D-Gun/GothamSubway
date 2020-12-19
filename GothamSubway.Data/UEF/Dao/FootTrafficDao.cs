using System;
using System.Collections.Generic;
using System.Linq;

namespace GothamSubway.Data
{
    public class FootTrafficDao : SingleKeyDao<FootTraffic, int>
    {
        internal FootTrafficDao() { }
        
        public List<FootTrafficTotalModel> GetMonthlyFootTraffics(int selectedYear, int stationNumber)
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                var queryTime = from x in context.FootTraffics
                            select new FootTrafficTotalModel
                            {
                                dailyTransferTotal = 0,
                                monthlyTransferTotal = 0,
                                date = x.Date,
                                transferId = x.TransferId,
                                stationId = x.StationId,
                                beforeSix = x.BeforeSix,
                                sixToSeven = x.SixToSeven,
                                sevenToEight = x.SevenToEight,
                                eightToNine = x.EightToNine,
                                nineToTen = x.NineToTen,
                                tenToEleven = x.TenToEleven,
                                elevenToTwelve = x.ElevenToTwelve,
                                twelveToThirteen = x.TwelveToThirteen,
                                thirteenToFourteen = x.ThirteenToFourteen,
                                fourteenToFifteen = x.FourteenToFifteen,
                                fifteenToSixteen = x.FifteenToSixteen,
                                sixteenToSeventeen = x.SixteenToSeventeen,
                                seventeenToEighteen = x.SeventeenToEighteen,
                                eighteenToNineteen = x.EighteenToNineteen,
                                nineteenToTwenty = x.NineteenToTwenty,
                                twentyToTwentyOne = x.TwentyToTwentyOne,
                                twentyOneToTwentyTwo = x.TwnetyOneToTwentyTwo,
                                twentyTwoToTwentyThree = x.TwentyTwoToTwentyThree,
                                twentyThreeToTwentyFour = x.TwentyThreeToTwentyFour,
                                afterTwentyFour = x.AfterTwentyFour
                            };
                queryTime = queryTime.Where(x => (x.date.Year == selectedYear) && (x.stationId == stationNumber)); // selected year에 해당하는 query 생성
                
                var queryDailyTotallist = queryTime.ToList();
                
                foreach (var item in queryDailyTotallist) 
                {
                    //일별 승 하차 합계 계산
                    item.dailyTransferTotal =
                        item.beforeSix +
                        item.sixToSeven +
                        item.sevenToEight +
                        item.eightToNine +
                        item.nineToTen +
                        item.tenToEleven +
                        item.elevenToTwelve +
                        item.twelveToThirteen +
                        item.thirteenToFourteen +
                        item.fourteenToFifteen +
                        item.fifteenToSixteen +
                        item.sixteenToSeventeen +
                        item.seventeenToEighteen +
                        item.eighteenToNineteen +
                        item.nineteenToTwenty +
                        item.twentyToTwentyOne +
                        item.twentyOneToTwentyTwo +
                        item.twentyTwoToTwentyThree +
                        item.twentyThreeToTwentyFour +
                        item.afterTwentyFour;
                    
                }
               return queryDailyTotallist;
            }
        }

        public List<int> GetAllYears()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.FootTraffics.Select(x => x.Date.Year).Distinct().ToList();
            }
        }
    }
}