namespace GothamSubway.Data
{
    public class Dao
    {
        public static ElectricityDao Electricity { get; } = new ElectricityDao();
        public static FootTrafficDao FootTraffic { get; } = new FootTrafficDao();
        public static RevenueDao Revenue { get; } = new RevenueDao();
        public static SatisfactionCategoryDao SatisfactionCategory { get; } = new SatisfactionCategoryDao();
        public static SatisfactionDao Satisfaction { get; } = new SatisfactionDao();
        public static StationDao Station { get; } = new StationDao();
        public static SubwayCardDao SubwayCard { get; } = new SubwayCardDao();
        public static TransferDao Transfer { get; } = new TransferDao();
    }
}
