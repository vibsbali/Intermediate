using System.Collections.Generic;

namespace Intermediate
{
    public class HttpCookie
    {
        private readonly Dictionary<int, Person> dictionary;

        public HttpCookie()
        {
            dictionary = new Dictionary<int, Person>();
        }

        public Person this[int key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }
        }
    }
}