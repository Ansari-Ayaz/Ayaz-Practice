using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class ref_out
    {
        public static void Add(ref int b)
        {

            b = ++b;
             
        }
        public static void Main(string[] args)
        {

            A obj = new B();
            
           
            Console.ReadLine();
        }
        
    }
    class A
    {
        public A()
        {
            Console.WriteLine("A Method");
        }
        public A(int x)
        {
            Console.WriteLine(x);
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B Method");
        }
    }
}
