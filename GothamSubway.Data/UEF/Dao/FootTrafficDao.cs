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
                var query = from x in context.FootTraffics
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
                                twentyToTwentyOne = x.TwentyToTwentyOne,
                                twentyOneToTwentyTwo = x.TwnetyOneToTwentyTwo,
                                twentyTwoToTwentyThree = x.TwentyTwoToTwentyThree,
                                twentyThreeToTwentyFour = x.TwentyThreeToTwentyFour,
                                afterTwentyFour = x.AfterTwentyFour
                            };
                query = query.Where(x => (x.date.Year == selectedYear) && (x.stationId == stationNumber)); // selected year에 해당하는 query 생성

            //    int month = int.Parse(birthdate) % 10000 / 100;
            //    int day = int.Parse(birthdate) % 100;

            //    //월,일이 틀릴 경우
            //    if (month < 1 || month > 12 || day < 1 || day > 31)
            //    {
            //        MessageBox.Show("생년월일을 정확하게 입력해 주세요", "Warning");
            //        return true;
            //    }
            //    //일이 틀릴 경우
            //    if (month % 2 == 0 && month < 7)
            //    {
            //        if (month == 2)
            //        {
            //            if (day > 28)
            //            {
            //                MessageBox.Show("생년월일을 정확하게 입력해 주세요", "Warning");
            //                return true;
            //            }
            //        }
            //        else if (day > 30)
            //        {
            //            MessageBox.Show("생년월일을 정확하게 입력해 주세요", "Warning");
            //            return true;
            //        }
            //    }
            //    else if (month == 9 && month == 11)
            //    {
            //        if (day > 30)
            //        {
            //            MessageBox.Show("생년월일을 정확하게 입력해 주세요", "Warning");
            //            return true;
            //        }
            //    }

            //    return false;
            //}

            //public static bool IsCellphoneValidationError(string cellphone)
            //{
            //    if (cellphone.Length < 11)
            //    {
            //        MessageBox.Show("전화번호를 양식에 맞게 입력해 주세요", "Warning");
            //        return true;
            //    }

            //    string identifier = cellphone.Substring(0, 3);
            //    if (identifier != "010")
            //    {
            //        MessageBox.Show("전화번호를 양식에 맞게 입력해 주세요", "Warning");
            //        return true;
            //    }
            //    return false;
            //}

            return query.ToList();
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