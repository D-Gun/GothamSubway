using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GothamSubway.Data
{
    public class SatisfactionDao : SingleKeyDao<Satisfaction, int>
    {
        internal SatisfactionDao() { }

        public List<int> GetAllYears()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Satisfactions.Select(x => x.Year.Year).Distinct().ToList();
            }
        }

        public List<SatisfactionModel> GetModels()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                List<Satisfaction> satisfactions = context.Satisfactions.ToList();

                List<SatisfactionModel> models = new List<SatisfactionModel>();

                foreach(var satisfaction in satisfactions)
                {
                    models.AddRange(new List<SatisfactionModel>()
                    {
                        new SatisfactionModel()
                        {
                            SatisfactionCategoryId = satisfaction.SatisfactionCategoryId,
                            SatisfactionCategory = satisfaction.SatisfactionCategory.Item,
                            SatisfactionItem = "매우좋음",
                            Persent = satisfaction.Excellent,
                            ColorData = Color.FromArgb(96,181,204),
                            Year = satisfaction.Year
                        },
                        new SatisfactionModel()
                        {
                            SatisfactionCategoryId = satisfaction.SatisfactionCategoryId,
                            SatisfactionCategory = satisfaction.SatisfactionCategory.Item,
                            SatisfactionItem = "좋음",
                            Persent = satisfaction.Good,
                            ColorData = Color.FromArgb(230,108,125),
                            Year = satisfaction.Year
                        },
                        new SatisfactionModel()
                        {
                            SatisfactionCategoryId = satisfaction.SatisfactionCategoryId,
                            SatisfactionCategory = satisfaction.SatisfactionCategory.Item,
                            SatisfactionItem = "보통",
                            Persent = satisfaction.Soso,
                            ColorData = Color.FromArgb(107,183,109),
                            Year = satisfaction.Year
                        },
                        new SatisfactionModel()
                        {
                            SatisfactionCategoryId = satisfaction.SatisfactionCategoryId,
                            SatisfactionCategory = satisfaction.SatisfactionCategory.Item,
                            SatisfactionItem = "나쁨",
                            Persent = satisfaction.Bad,
                            ColorData = Color.FromArgb(240,173,0),
                            Year = satisfaction.Year
                        },
                        new SatisfactionModel()
                        {
                            SatisfactionCategoryId = satisfaction.SatisfactionCategoryId,
                            SatisfactionCategory = satisfaction.SatisfactionCategory.Item,
                            SatisfactionItem = "매우나쁨",
                            Persent = satisfaction.Terrible,
                            ColorData = Color.FromArgb(232,134,81),
                            Year = satisfaction.Year
                        },
                    });
                }
                return models;
            }
        }
    }
}