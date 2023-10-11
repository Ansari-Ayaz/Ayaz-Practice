using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    static class Product
    {
        static int Id;
        static string Name;
        static double Price;

        static Product()
        {
            Id = 1;
            Name = "Mobile";
            Price = 5000;

        }



        public static void ProductDetail()
        {
            Console.WriteLine("Product Id is: {0}", Id);
            Console.WriteLine("Product Name is: {0}", Name);
            Console.WriteLine("Product Price is: {0}", Price);
        }

        public static void DiscountDetail()
        {
            double discount = Price / 500;
            Console.WriteLine("Discount is: {0}", discount);
            Console.WriteLine("Total Cost of Product is:{0}", (Price - discount));
        }
    }
    sealed class Gadget
    {
        public void Listening()
        {
            Console.WriteLine("Hello");
        }


    }
    class Oneplus
    {
        public void Listening1()
        {
            Console.WriteLine("Low Volume");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            string input = "CAT";
            CheckString(input);
            Console.Read();
            ///////// Bubble Sorting ///////////////////////////
            int[] numbers = { 5, 4, 3, 2, 1 };
            var temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = (i + 1); j < numbers.Length; j++)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            foreach (int i in numbers)
            {
                Console.Write("{" + i + "}");
            }
            Oneplus gadget = new Oneplus();
            gadget.Listening1();

            Mobile mobile = new Mobile();
            mobile.Name = "Ayaz";
            mobile.Age = 12;
            Mobile mobile2 = new Mobile();
            mobile2.Name = " Ansari";
            mobile2.Age = 15;
            Mobile mobile3 = new Mobile();
            mobile3 = mobile + mobile2;
            ////////// Pyramide Star Pattern ////////////////////
            Console.WriteLine("Enter Length of Pyramid");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                for (int j = length; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            ////////// Even And Odd Number Check Method /////////
            Console.WriteLine(CheckEvenOddNumber());


            //////////// Pallindrome Check //////////////////////
            Console.WriteLine("Please Enter Number");
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            var reverString = number.ToString();
            var reverString1 = reverString.Reverse();
            var reverString2 = string.Join("", reverString1);
            bool pallinCheck = string.Equals(reverString, reverString2);
            if (pallinCheck)
            {
                Console.WriteLine("this is pallindrome");
            }
            else
            {
                Console.WriteLine("this is not pallindrome");
            }
            Product.ProductDetail();
            Product.DiscountDetail();
            Console.ReadLine();


            var a = Base64Encode("Ayaz Ansari");
            var b = Base64Decode(a);

            Ticket ticket = new Ticket();
            ticket.PNR = "1234";
            ticket.Source = "Mumbai";
            ticket.Destination = "Pune";
            ticket.ArrivalTime = DateTime.Parse("2022-07-09");
            ticket.DepartureTime = DateTime.Parse("2022-07-10");

            FareDetail fareDetail = new FareDetail();
            fareDetail.TicketPrice = 1000;
            //fareDetail.GST = 180;
            fareDetail.Discount = 10;

            ticket.Fare = fareDetail;


            List<Passenger> passengers = new List<Passenger>();
            Passenger passenger1 = new Passenger();
            passenger1.PassengerName = "Mohd Zaid";
            passenger1.PassengerAge = 29;
            passenger1.PassengerGender = "M";
            passengers.Add(passenger1);

            Passenger passenger2 = new Passenger();
            passenger2.PassengerName = "Mohd Faiz";
            passenger2.PassengerAge = 25;
            passenger2.PassengerGender = "M";
            passengers.Add(passenger2);

            Passenger passenger3 = new Passenger();
            passenger3.PassengerName = "Mohsin K";
            passenger3.PassengerAge = 38;
            passenger3.PassengerGender = "M";
            passengers.Add(passenger3);

            ticket.Passengers = passengers;



            Console.ReadKey();
        }
        static void CheckString(string stringInput)
        {
            var countInput = stringInput.Length;
            int count = 0;
            string sampleInput = "terca";
            stringInput = stringInput.ToLower();
            char[] allCharacters = stringInput.ToArray();
            foreach (var i in allCharacters)
            {
                bool having = stringInput.Any(c => c.Equals(i));
                if (having)
                {
                    count++;
                }
            }
            if (countInput == count)
            {
                Console.WriteLine("Input string is fully matched with sample string");
            }
            Console.WriteLine("Input string is not matched with sample string");

        }

        public static string CheckEvenOddNumber()
        {
            Console.WriteLine("PLease enter number");
            int num = int.Parse(Console.ReadLine());
            int rem = num % 2;
            if (rem == 0)
            {
                return "this is even number";
            }
            else { return "this is odd number"; }
        }

        public void ControllerMethod(Ticket objTicket)
        {

            SaveFare(objTicket.Fare);

        }

        public void SaveFare(FareDetail objFare)
        {

        }

        public static bool UpdateEmployee(Employee emp)
        {
            string connectionString0 = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(connectionString0))
            {
                string query = "update AyazEmployee set age=" + emp.Age + "where id=" + emp.Id;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var sdr = cmd.ExecuteNonQuery();
                if (sdr > 0)
                    return true;
                else
                    return false;
            }
        }


        public static bool SaveEmployee(Employee emp)
        {
            string conectionString = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = "insert into AyazEmployee values ('" + emp.Name + "'," + emp.Age + ",'" + emp.DateOfBirth.ToString("yyyy-MM-dd") + "','" + emp.Gender + "','" + emp.Designation + "','" + emp.City + "','" + emp.Country + "'," + emp.Salary + ",1)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var sdr = cmd.ExecuteNonQuery();
                if (sdr > 0)
                    return true;
                else
                    return false;
            }
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            string conectionString = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = "select * from AyazEmployee";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Name = sdr["Name"].ToString();
                    employee.Age = int.Parse(sdr["Age"].ToString());
                    employee.City = sdr["City"].ToString();
                    employee.Designation = sdr["Designation"].ToString();
                    employee.DateOfBirth = DateTime.Parse(sdr["DateOfBirth"].ToString());
                    employee.Gender = sdr["Gender"].ToString();
                    employee.Country = sdr["Country"].ToString();
                    employee.Salary = double.Parse(sdr["Salary"].ToString());
                    employee.Id = int.Parse(sdr["id"].ToString());
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public static List<Employee> GetAllActiveEmployees()
        {
            List<Employee> employees = new List<Employee>();

            string conectionString = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = "select * from AyazEmployee where IsActive=1";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Employee employee = new Employee();
                    employee.Name = sdr["Name"].ToString();
                    employee.Age = int.Parse(sdr["Age"].ToString());
                    employee.City = sdr["City"].ToString();
                    employee.Designation = sdr["Designation"].ToString();
                    employee.DateOfBirth = DateTime.Parse(sdr["DateOfBirth"].ToString());
                    employee.Gender = sdr["Gender"].ToString();
                    employee.Country = sdr["Country"].ToString();
                    employee.Salary = double.Parse(sdr["Salary"].ToString());
                    employee.Id = int.Parse(sdr["id"].ToString());
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public static Employee GetEmployeeById(int Id)
        {
            string connectionString0 = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(connectionString0))
            {
                string query = "select * from AyazEmployee where Id=" + Id;

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var sdr = cmd.ExecuteReader();
                Employee detailEmployee = new Employee();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        detailEmployee.Id = int.Parse(sdr["Id"].ToString());
                        detailEmployee.Name = sdr["Name"].ToString();
                        detailEmployee.Age = int.Parse(sdr["Age"].ToString());
                        detailEmployee.DateOfBirth = DateTime.Parse(sdr["DateOfBirth"].ToString());
                        detailEmployee.Gender = sdr["Gender"].ToString();
                        detailEmployee.Designation = sdr["Designation"].ToString();
                        detailEmployee.City = sdr["City"].ToString();
                        detailEmployee.Country = sdr["Country"].ToString();
                        detailEmployee.Salary = Double.Parse(sdr["Salary"].ToString());
                        detailEmployee.IsActive = bool.Parse(sdr["IsActive"].ToString());

                    }
                }
                return detailEmployee;


            }




        }

        public static List<Employee> GetAllEmployeeByStatus(bool status)
        {
            string connectionString = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // (condition) ? "A" : ""
                var condition = status ? 1 : 0;
                string query = "select * from AyazEmployee where IsActive='" + condition + "' ";

                SqlCommand cmd = new SqlCommand(query, con);
                Employee activeEmployee = new Employee();
                con.Open();
                var sdr = cmd.ExecuteReader();
                List<Employee> ActiveEmpList = new List<Employee>();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = int.Parse(sdr["Id"].ToString());
                        emp.Name = sdr["Name"].ToString();
                        emp.Age = int.Parse(sdr["Age"].ToString());
                        emp.DateOfBirth = DateTime.Parse(sdr["DateOfBirth"].ToString());
                        emp.Gender = sdr["Gender"].ToString();
                        emp.Designation = sdr["Designation"].ToString();
                        emp.City = sdr["City"].ToString();
                        emp.Country = sdr["Country"].ToString();
                        emp.Salary = double.Parse(sdr["Salary"].ToString());
                        emp.IsActive = bool.Parse(sdr["IsActive"].ToString());
                        ActiveEmpList.Add(emp);
                    }
                }
                return ActiveEmpList;

            }
        }

        public static List<Employee> GetEmployeeByCity(String empCity)
        {
            string connectionString = "Data Source=alphadigitall.com;Initial Catalog= RnD;User Id=developer;Password= DB@Pwd123;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string query = "select * from AyazEmployee where City=" + empCity;

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var sdr = cmd.ExecuteReader();
                List<Employee> ActiveEmpList = new List<Employee>();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = int.Parse(sdr["Id"].ToString());
                        emp.Name = sdr["Name"].ToString();
                        emp.DateOfBirth = DateTime.Parse(sdr["DateOfBirth"].ToString());
                        emp.Age = int.Parse(sdr["Age"].ToString());
                        emp.Gender = sdr["Gender"].ToString();
                        emp.Designation = sdr["Designation"].ToString();
                        emp.City = sdr["City"].ToString();
                        emp.Country = sdr["Country"].ToString();
                        emp.Salary = double.Parse(sdr["Salary"].ToString());
                        emp.IsActive = bool.Parse(sdr["IsActive"].ToString());
                        ActiveEmpList.Add(emp);
                    }
                }
                return ActiveEmpList;

            }
        }

        public static void PallindromeCheck()
        {
            Console.WriteLine("Please Enter Word");
            var a = Console.ReadLine();
            var b = a.ReverseString();
            Console.WriteLine(a.Equals(b));
            PallindromeCheck();
        }

        public static void OddEvenCheck()
        {
            Console.WriteLine("Please Enter Number");
            int a = int.Parse(Console.ReadLine());

            Bike unicorn = new Bike();
            unicorn.ModelYear = 2019;
            unicorn.RefillFuel();
            unicorn.RideBike();

            Car nexon = new Car();
            nexon.ModelYear = 2022;
            nexon.RefillFuel();
            nexon.DriveCar();

            OddEvenCheck();
        }

        public static void NumberOfPostShow()
        {
            Console.WriteLine("Please Enter Name");
            string inputString = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(inputString))
            {
                string[] nameString = inputString.Split(' ');
                int lenthOfString = nameString.Length;
                if (lenthOfString == 1)
                {
                    Console.WriteLine(nameString[0] + "Likes Your Post");
                }
                else if (lenthOfString == 2)
                {
                    Console.WriteLine(nameString[0] + "," + nameString[1] + "Likes Your Post");
                }
                else if (lenthOfString >= 3)
                {
                    Console.WriteLine(nameString[0] + "," + nameString[1] + ",Many More Likes Your Post ");
                }
                //else
                //    Console.WriteLine("");
            }
        }

        public static void NumberRepitationError()
        {
            Console.WriteLine("Please enter Number's");
            List<int> Numbererrors = new List<int>();
            do
            {
                int inputNumber = int.Parse(Console.ReadLine());
                bool repeatedNumber = Numbererrors.Contains(inputNumber);
                if (repeatedNumber)
                {
                    Console.WriteLine("Number Repeated Error");
                    break;
                }
                else
                {
                    Numbererrors.Add(inputNumber);
                }


            } while (true);

        }

        /* String Methods Practice */

        //string test = "Ayaz Ansari";
        //string test1 = "Ansari";
        //string test2 = "Ayaz Ansari";
        ////string test1 = "Language ";
        ////string repString = test.Replace("C#", "Programming");
        ////string repString = string.Format(" {0}Fun{1}", test,test1);
        ////string[] characters = test.Split(' ');
        ////string test1 = test.Substring(3);
        ////int result = string.Compare(test,test2);
        ////bool result = test.Contains("shaikh");
        //char[] character = { 'z' };
        ////string result = string.Concat(test, test1);
        ////string trimResult = test.Trim();
        ////bool stringComparision = string.Equals(test, test2);
        ////int result = test.LastIndexOf('a');
        ////string result = test.Remove(3, 3);
        ////bool result = test.EndsWith("Ansari");
        ///

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }


    public static class ExtensionMethod
    {
        public static string ReverseString(this string a)
        {
            var c = a.ToArray().Reverse();
            var d = string.Join("", c);
            return d;
        }

    }



}










