using System;

namespace Intermediate
{
    public class Person
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                return timeSpan.Days / 365;
            }
        }

        public string Name { get; set; }
    }
}