using System.Collections.Generic;

namespace Intermediate
{
    public class Customer
    {
        public int Id;

        public readonly List<Order> Orders;
        public string Name { get; set; }

        public Customer(int id)
        {
            Id = id;
            Orders = new List<Order>();
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }
    }
}