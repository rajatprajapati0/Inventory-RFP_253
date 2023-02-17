using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
   public class Seed
    {
        public string BrandName { get; set; }
        public int Wight{ get; set; }
        public int price { get; set; }


        public override string ToString()
        {
            return
            $"Brand-{BrandName}\n" +
            $"wight-{Wight}\n" +
            $"Price-{price}\n";


        }


    }




}
