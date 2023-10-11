using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Mobile
    {
        //public string Name { get; set; }
        //public int RefreshRate { get; set; }
        //public bool IP68 { get; set; }
        //public string MobileNumber { get; }
        //public double Price { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public static Mobile operator +(Mobile obj1, Mobile obj2)
        {
            Mobile mob3 = new Mobile();
            mob3.Name = obj1.Name + obj2.Name;
            mob3.Age = obj1.Age + obj2.Age;
            return mob3;

        }
    }
}
