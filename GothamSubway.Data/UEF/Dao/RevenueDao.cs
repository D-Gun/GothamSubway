using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GothamSubway.Data
{
    public class RevenueDao : SingleKeyDao<Revenue, int>
    {
        internal RevenueDao() { }

        public List<Revenue> GetByYear(int year)
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Revenues.Where(x => x.Month.Year == year).ToList();
            }
        }

        public List<int> GetAllYears()
        {
            using (var context = DbContextCreator.Create())
            {
                return context.Revenues.Select(x => x.Month.Year).Distinct().ToList();
            }
        }
    }
}