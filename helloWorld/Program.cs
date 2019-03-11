using System;

namespace helloWorld
{ 
    // Enums 

    //public enum ShippingMethod
    //{
    //    RegularMail = 10,
    //    RegisterdMail = 15,
    //    Express = 30
    //}
    class MainClass
    {
       public static void Main(string[] args)
       {
            //Strings
            //var firstName = "Matthew";
            //var lastName = "Dodi";
            //var fullName = String.Format("My name is {0} {1}", firstName, lastName);

            //var strArray = new String[] { "One", "Two", "Three" };

            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.Write("[{0},", strArray[i]);
            //    }
            //    else if (i != 0 && i != strArray.Length - 1)
            //    {
            //        Console.Write(" {0},", strArray[i]);
            //    } 
            //    else if (i == strArray.Length - 1)
            //    {
            //        Console.Write(" {0}]", strArray[i]);
            //    }
            //}

            //var numbers = new string[3] { "One", "Two", "Three" };
            //var numbersJoined = String.Join(" ", numbers);
            //Console.WriteLine(numbersJoined);

            // Console.WriteLine((int)ShippingMethod.RegularMail);

            //int hour = 1;
            //Type t = hour.GetType();
            //Console.WriteLine(t == typeof(Int64));

            //while (true)
            //{
            //    Console.WriteLine("Type Your Name: ");
            //    string input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine(input);
            //        continue;
            //    }

            //    break;
            //}

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number type OK to exit");
                string input = Console.ReadLine();
                if (input == "OK" || input == "ok")
                {
                    break;
                }
                else
                {
                    Int32.TryParse(input, out int num);
                    sum += num;
                }
            }

            Console.WriteLine(sum);
        }
    }
} 