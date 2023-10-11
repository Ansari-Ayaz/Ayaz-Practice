using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Bike : Vehicle
    {
        public int ModelYear { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public bool Abs { get; set; }
        public bool HaveSideStand { get;set; }

        public void RideBike()
        {
            Console.WriteLine("Riding Bike");
        }

      
    }
}
