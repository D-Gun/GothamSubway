using System.Collections.Generic;
using System.Linq;
namespace GothamSubway.Data
{
    public class ElectricityDao : SingleKeyDao<Electricity, int>
    {
        internal ElectricityDao() { }

        public List<ElectricityModel> GetModels()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Electricities
                            select new ElectricityModel
                            {
                                Usage = x.Usage,
                                Bill = x.Bill
                            };

                return query.ToList();
            }
        }

        public List<ElectricityItem> GetElectricity()
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Electricities
                            select new ElectricityItem
                            {
                                Month = x.Month,
                                Usage = x.Usage,
                                Bill = x.Bill
                            };

                List<ElectricityItem> items = query.ToList();
                
                foreach(var x in items)
                {
                    x.Monthdate = x.Month.ToString("MM");
                }

                return items;
            }
        }

        public List<ElectricityItem> GetUsageByYear(string year)
        {
            using (GothamSubwayEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Electricities
                            select new ElectricityItem
                            {
                                Monthdate = x.Month.ToString("MM"),
                                Usage = x.Usage,
                            };
                query.Where(x => x.Monthdate == year);

                return query.ToList();
            }
        }
    }
}
