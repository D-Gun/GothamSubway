using System.Collections.Generic;
using System.Linq;
namespace GothamSubway.Data
{
    public class ElectricityDao : SingleKeyDao<Electricity, int>
    {
        internal ElectricityDao() { }

        // 예시!!!!!!!!!!!!!
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
    }
}
