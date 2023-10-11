using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Vehicle 
    {
        public int ModelYear { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        public void RefillFuel()
        {
            Console.WriteLine("Fuel Refilled");
        }
    }
}
