using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotterBook
{
    public static class BookShop
    {
        public static double BookPrice { get; private set; }

        private static Dictionary<int, double> discounts;
        public static IReadOnlyDictionary<int, double> Discounts
        {
            get
            {
                return discounts as IReadOnlyDictionary<int, double>;
            }
        }
        static BookShop()
        {
            BookPrice = 8;
            discounts = new Dictionary<int, double>()
            {
                {2, 0.05},
                {3, 0.10},
                {4, 0.20},
                {5, 0.25}
            };
        }




    }
}
