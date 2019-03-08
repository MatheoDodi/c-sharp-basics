using System;
namespace helloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public string Introduce()
        {
            return "Hello, my name is" + FirstName + " " + LastName;
        }

    }
}
