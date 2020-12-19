using System;
using System.Collections.Generic;
using System.Linq;

namespace GothamSubway.Data
{
    public class FootTrafficDao : SingleKeyDao<FootTraffic, int>
    {
        internal FootTrafficDao() { }

        public DateTime GetMinimumDate()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                return context.FootTraffics.Select(x => x.Date).OrderBy(x => x).FirstOrDefault();
            }
        }

        public DateTime GetMaximumDate()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                return context.FootTraffics.Select(x => x.Date).OrderByDescending(x => x).FirstOrDefault();
            }
        }

        public List<FootTrafficDurationSumModel> GetDurationSumModel()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                return (from x in context.FootTraffics
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

        public List<FootTrafficDurationAverageModel> GetDurationAverageModel(DateTime start, DateTime end)
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                var query = from x in context.FootTraffics
                        where (start <= x.Date && x.Date <= end)
                        group x by new { StationId = x.StationId, TransferId = x.TransferId } into g
                        select new
                        {
                            StationId = g.Key.StationId,
                            TransferId = g.Key.TransferId,
                            BeforeSix = g.Average(a => a.BeforeSix),
                            SixToSeven = g.Average(a => a.SixToSeven),
                            SevenToEight = g.Average(a => a.SevenToEight),
                            EightToNine = g.Average(a => a.EightToNine),
                            NineToTen = g.Average(a => a.NineToTen),
                            TenToEleven = g.Average(a => a.TenToEleven),
                            ElevenToTwelve = g.Average(a => a.ElevenToTwelve),
                            TwelveToThirteen = g.Average(a => a.TwelveToThirteen),
                            ThirteenToFourteen = g.Average(a => a.ThirteenToFourteen),
                            FourteenToFifteen = g.Average(a => a.FourteenToFifteen),
                            FifteenToSixteen = g.Average(a => a.FifteenToSixteen),
                            SixteenToSeventeen = g.Average(a => a.SixteenToSeventeen),
                            SeventeenToEighteen = g.Average(a => a.SeventeenToEighteen),
                            EighteenToNineteen = g.Average(a => a.EighteenToNineteen),
                            NineteenToTwenty = g.Average(a => a.NineteenToTwenty),
                            TwentyToTwentyOne = g.Average(a => a.TwentyToTwentyOne),
                            TwnetyOneToTwentyTwo = g.Average(a => a.TwnetyOneToTwentyTwo),
                            TwentyTwoToTwentyThree = g.Average(a => a.TwentyTwoToTwentyThree),
                            TwentyThreeToTwentyFour = g.Average(a => a.TwentyThreeToTwentyFour),
                            AfterTwentyFour = g.Average(a => a.AfterTwentyFour)
                        };

                List<FootTrafficDurationAverageModel> footTrafficDurationAverageModels = new List<FootTrafficDurationAverageModel>();

                foreach(var item in query)
                {
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "6시이전", Average = item.BeforeSix });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "6~7", Average = item.SixToSeven });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "7~8", Average = item.SevenToEight });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "8~9", Average = item.EightToNine });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "9~10", Average = item.NineToTen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "10~11", Average = item.TenToEleven });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "11~12", Average = item.ElevenToTwelve });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "12~13", Average = item.TwelveToThirteen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "13~14", Average = item.ThirteenToFourteen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "14~15", Average = item.FourteenToFifteen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "15~16", Average = item.FifteenToSixteen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "16~17", Average = item.SixteenToSeventeen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "17~18", Average = item.SeventeenToEighteen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "18~19", Average = item.EighteenToNineteen });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "19~20", Average = item.NineteenToTwenty });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "20~21", Average = item.TwentyToTwentyOne });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "21~22", Average = item.TwnetyOneToTwentyTwo });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "22~23", Average = item.TwentyTwoToTwentyThree });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "23~24", Average = item.TwentyThreeToTwentyFour });
                    footTrafficDurationAverageModels.Add(new FootTrafficDurationAverageModel() { StationId = item.StationId, TransferId = item.TransferId, Time = "24시이후", Average = item.AfterTwentyFour });
                }

                return footTrafficDurationAverageModels;
            }
        }

        public List<FootTrafficMonthlyTotalModel> GetMonthlyFootTraffics(int selectedYear, int stationNumber)
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

                List<FootTrafficMonthlyTotalModel> footTrafficMonthlyTotalModels = new List<FootTrafficMonthlyTotalModel>();

                foreach (var item in queryDailyTotalList)
                {
                    FootTrafficMonthlyTotalModel find = footTrafficMonthlyTotalModels
                        .Find(x => x.date.Year == item.date.Year &&
                        x.date.Month == item.date.Month &&
                        x.stationId == item.stationId &&
                        x.transferId == item.transferId);
                    
                    if (find == null)
                    {
                        find = new FootTrafficMonthlyTotalModel()
                        {
                            date = new DateTime(item.date.Year, item.date.Month, 1),
                            stationId = item.stationId,
                            transferId = item.transferId
                        };
                        footTrafficMonthlyTotalModels.Add(find);
                    }

                    find.monthlytotal += item.dailyTransferTotal;
                }
                return footTrafficMonthlyTotalModels;
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