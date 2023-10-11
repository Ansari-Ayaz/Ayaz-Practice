using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Car : Vehicle
    {
       
        public bool IsCNG { get; set; }

        public void DriveCar()
        {
            Console.WriteLine("Driving Car");
        }

        
    }
}
