using System;

namespace helloWorld
{ 
    // Enums 

    public enum ShippingMethod
    {
        RegularMail = 10,
        RegisterdMail = 15,
        Express = 30
    }
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

            int hour = 1;

            string answer = hour == 1 ? "Yes" : "No";
            Console.WriteLine(answer);
        }
    }
} 