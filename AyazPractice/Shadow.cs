using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Shadow
    {
        public  void Display()
        {
            Console.WriteLine("Base Class Method");
        }

    }
    public class Derive : Shadow
    {
        public new void Display()
        {
            Console.WriteLine("Derived class Method");
        }
    }
    public class Shodowing
    {
        static void Main(string[] args)
        {
            //Shadow baseObj = new Shadow();
            //Derive deriveObj = new Derive();
            ////baseObj.Display();
            //deriveObj.Display();
            //Shadow baseObj = new Derive();
            //baseObj.Display();

            //Type myTypeClass = typeof(Derive);
            //object myObj = Activator.CreateInstance(myTypeClass);
            //MethodInfo mInfo = myTypeClass.GetMethod("Display");
            //mInfo.Invoke(myObj, new Object[] {"Display Reflection"});

            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Get the type of the class
            Type personType = person.GetType();

            // Get properties using reflection
            PropertyInfo[] properties = personType.GetProperties();

            Console.WriteLine("Properties of the Person class:");
            foreach (var property in properties)
            {
                Console.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType}");
            }

            // Invoke a method using reflection
            MethodInfo sayHelloMethod = personType.GetMethod("SayHello");
            sayHelloMethod.Invoke(person, null);
            Console.Read();
        }

    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
