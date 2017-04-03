using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programming_COP2360_228883_4
{
    public static class BagOrder
    {
        public static class Quantity
        {
            public static readonly int MaxQuantity = 10;
        }

        public static class Shipping
        {
            public static readonly int Overnight = 10;
            public static readonly int ThreeDay = 7;
            public static readonly int Standard = 5;
        }

        public static List<BagType> BagTypes
        {
            get { return BagTypes; }
            set {  }
        }

        public struct BagType
        {
            public string Name { get; set; }
            public int Price { get; set; }
            
        }
    }
}
