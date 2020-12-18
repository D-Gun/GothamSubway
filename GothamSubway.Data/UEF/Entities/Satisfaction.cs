using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamSubway.Data
{
    public partial class Satisfaction
    {
    }

    public class SatisfactionModel
    {
        public DateTime Year { get; set; }
        public int SatisfactionCategoryId { get; set; }
        public string SatisfactionCategory { get; set; }
        public string SatisfactionItem { get; set; }
        public decimal Persent { get; set; }
        public Color ColorData { get; set; }
    }
}
