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
                    item.monthlyTransferTotal = item.dailyTransferTotal;
                }

                var queryMonthlylist = from x in queryDailyTotallist
                                       select new FootTrafficMonthlyTotalModel
                                       {
                                           date = x.date,
                                           dailyTransferTotalForMonthlyTotal = x.dailyTransferTotal,
                                           monthlytotal = 0
                                       };
                foreach (var item in queryMonthlylist)
                {
                    if (item.date.Month == 01)
                    {
                        item.monthlytotal = item.dailyTransferTotalForMonthlyTotal.
                    }
                    
                }
                

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