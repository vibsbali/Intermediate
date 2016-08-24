using System;

namespace Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Id = 1,
                Name = "Vaibhav"
            };

            var personTwo = new Person()
            {
                Id = 2,
                Name = "Sheebu"
            };

            var cookie = new HttpCookie();
            cookie[person.Id] = person;
            cookie[personTwo.Id] = personTwo;

            Console.WriteLine($"Name is {cookie[1].Name}");

        }
    }
}
