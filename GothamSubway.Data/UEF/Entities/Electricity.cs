using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamSubway.Data
{
    public partial class Electricity
    {
    }

    public class ElectricityItem
    {
        public DateTime Month { get; set; }
        public string Monthdate { get; set; }
        public int Usage { get; set; }
        public int Bill { get; set; }
        //public int IncOrDecRate
    }

    public class ElectricityModel
    {
        private static Random random = new Random();
        public ElectricityModel()
        {
            Number = random.Next(20);
            SymbolColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        public int Usage { get; set; }
        public int Bill { get; set; }
        public int Number { get; set; }
        public Color SymbolColor { get; set; }
    }
}
