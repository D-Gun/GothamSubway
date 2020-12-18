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
                                Bill = x.Bill,
                            };

                List<ElectricityItem> items = query.ToList();
                
                for (int i = 0; i < items.Count; i++)
                {
                    ElectricityItem previousItem = items.Find(x => x.Month.Year == (items[i].Month.Year -1) && x.Month.Month == items[i].Month.Month);

                    if (previousItem == null)
                    {
                        items[i].UsageYoYRate = 0;
                        items[i].BillYoYRate = 0;
                    }
                    else
                    {
                        items[i].UsageYoYRate = (items[i].Usage - previousItem.Usage) / (double)previousItem.Usage * 100.0;
                        items[i].BillYoYRate = (items[i].Bill - previousItem.Bill) / (double)previousItem.Bill * 100.0;
                    }
                }

                foreach (var x in items)
                {
                    x.Monthdate = x.Month.ToString("MM");
                }
                return items;
            }
        }
    }
}
