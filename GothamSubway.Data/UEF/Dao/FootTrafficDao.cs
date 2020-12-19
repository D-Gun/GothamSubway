using System;
using System.Collections.Generic;
using System.Linq;

namespace GothamSubway.Data
{
    public class FootTrafficDao : SingleKeyDao<FootTraffic, int>
    {
        internal FootTrafficDao() { }

        public List<FootTrafficDurationSumModel> GetDurationSumModel(DateTime start, DateTime end)
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                return (from x in context.FootTraffics
                        where (DateTime.Compare(start, x.Date) < 0 && DateTime.Compare(x.Date, end) > 0)
                        select new FootTrafficDurationSumModel
                        {
                            Date = x.Date,
                            StationId = x.StationId,
                            TransferId = x.TransferId,
                            Sum = x.BeforeSix + x.SixToSeven + x.SevenToEight + x.EightToNine + x.NineToTen + x.TenToEleven + x.ElevenToTwelve +
                             x.TwelveToThirteen + x.ThirteenToFourteen + x.FourteenToFifteen + x.FifteenToSixteen + x.SixteenToSeventeen +
                             x.SeventeenToEighteen + x.EighteenToNineteen + x.TwentyToTwentyOne + x.TwnetyOneToTwentyTwo +
                             x.TwentyTwoToTwentyThree + x.TwentyThreeToTwentyFour + x.AfterTwentyFour
                        }).ToList();
            }
        }

        //DateTime dttmA = Convert.ToDateTime("2017-01-01"), dttmB = DateTime.Now;
        /* 
         * compareResult가 0보다 작은경우 : dttmA < dttmB 
         * compareResult가 0인 경우 : dttmA = dttmB 
         * compareResult가 0보다 큰경우 : dttmA > dttmB 
         */
        //int compareResult = DateTime.Compare(dttmA, dttmB);

        public List<FootTrafficDurationAverageModel> GetDurationAverageModel(DateTime start, DateTime end)
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                return (from x in context.FootTraffics
                        where (DateTime.Compare(start, x.Date) < 0 && DateTime.Compare(x.Date, end) > 0)
                        group x by new { StationId = x.StationId, TransferId = x.TransferId } into g
                        select new FootTrafficDurationAverageModel
                        {
                            StationId = g.Key.StationId,
                            TransferId = g.Key.TransferId,
                            BeforeSix = g.Average(a => a.BeforeSix),
                            SixToSeven = g.Average(a => a.SixToSeven)
                        }).ToList();
            }
        }

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
                
                var queryDailyTotalList = queryTime.ToList();
                
                foreach (var item in queryDailyTotalList) 
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

                var queryMonthlyTotalList = from x in queryDailyTotalList
                                            select new FootTrafficMonthlyTotalModel
                                            {
                                                date = x.date,
                                                stationId = x.stationId,
                                                transferId = x.transferId,
                                                dailytotal = x.dailyTransferTotal,
                                                monthlytotal = 0
                                            };
                foreach (var item in queryMonthlyTotalList)
                {
                    if (item.date.Month == 1)
                    {
                        item.monthlytotal += item.dailytotal;
                    }
                }
               return queryDailyTotalList;
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