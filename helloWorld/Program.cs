using System;

namespace helloWorld
{ 
class MainClass
    {
       public static void Main(string[] args)
        { 
            //Strings
            var firstName = "Matthew";
            var lastName = "Dodi";
            var fullName = String.Format("My name is {0} {1}", firstName, lastName);

            var strArray = new String[] { "One", "Two", "Three" };

            for (int i = 0; i < strArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("[{0},", strArray[i]);
                }
                else if (i != 0 && i != strArray.Length - 1)
                {
                    Console.Write(" {0},", strArray[i]);
                } 
                else if (i == strArray.Length - 1)
                {
                    Console.Write(" {0}]", strArray[i]);
                }
            }
        }
    }
}