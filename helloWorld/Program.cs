using System;
using System.Linq;
using System.Collections.Generic;

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



            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Please enter a number type OK to exit");
            //    string input = Console.ReadLine();
            //    if (input == "OK" || input == "ok")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Int32.TryParse(input, out int num);
            //        sum += num;
            //    }
            //}

            //Console.WriteLine(sum);




            //string inputString = Console.ReadLine();
            //Int32.TryParse(inputString, out int inputNumber);
            //int total = 1;

            //for (int i = inputNumber; i > 0; i--)
            //{
            //    total *= i;
            //}

            //Console.WriteLine("{0}!= {1}", inputString, total);



            //int rng = new Random().Next(1, 10);

            //for (int i = 0; i < 4; i++)
            //{
            //    var inputString = Console.ReadLine();
            //    Int32.TryParse(inputString, out int inputNum);
            //    if (inputNum == rng)
            //    {
            //        Console.WriteLine("You Won!");
            //        break;
            //    }
            //}


            //string userInput = Console.ReadLine();

            //string[] strArr = userInput.Split(',');

            //List<int> nums = new List<int>();

            //foreach(string value in strArr)
            //{
            //    Int32.TryParse(value.Trim(), out int output);
            //    nums.Add(output);
            //}

            //int maxNum = nums.ToArray().Max();
            //Console.WriteLine(maxNum);

            //var numbers = new List<int>() { 1, 2, 3, 4, 1 };
            //Console.WriteLine(numbers.LastIndexOf(1, 4));
            //string fullName = "Matthew Dodi";
            //Console.WriteLine(fullName);

            // GRADES

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.2f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            string fullName = "   Matthew Dodi   ";
            string newName = fullName.Trim();
            Console.WriteLine(newName);
        }
    }
} 