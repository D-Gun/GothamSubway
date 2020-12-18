using System.Collections.Generic;
using System.Linq;

namespace GothamSubway.Data
{
    public class SatisfactionCategoryDao : SingleKeyDao<SatisfactionCategory, int>
    {
        internal SatisfactionCategoryDao() { }

        public List<SatisfactionCategory> GetUpperCategory()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                return context.SatisfactionCategories
                    .Where(x => x.UpperId == null)
                    .OrderBy(x => x.SatisfactionCategoryId)
                    .ToList();
            }
        }
    }
}