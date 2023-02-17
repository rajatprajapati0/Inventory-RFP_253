using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    public class Inventory
    {
        public List<Seed> Rice { get; set; }
        public List<Seed> Wheats { get; set; }
        public List<Seed> Pulses { get; set; }

        public Inventory()
        {
            Rice = new List<Seed>();
            Wheats = new List<Seed>();
            Pulses = new List<Seed>();
        }
        public override string ToString()
        {
            {
                string result = "";
                result += "\nRice:\n";
                foreach (Seed item in Rice)
                {
                    result += item.ToString();

                    
                }



                
                result += "\nWheat:\n";
                foreach (Seed item in Wheats)
                {
                    result += item.ToString();

                   
                }




               
                result += "\nPulses:\n";
                foreach (Seed item in Pulses)
                {
                    result += item.ToString();


                   
                }


                return result;
            }

        }
    }
}