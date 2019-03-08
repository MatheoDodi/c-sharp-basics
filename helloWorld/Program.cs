using System;

namespace helloWorld
{
    class MainClass
    {
       public static void Main(string[] args)
        {
            try
            {
                string number = "1234";
                int num = Convert.ToByte(number);
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("The number is too large to be stores in a byte");
            }
        }
    }
}