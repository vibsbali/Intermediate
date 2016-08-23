namespace Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Vaibhav");

            person.Introduce("Sheebu");
        }
    }
}
