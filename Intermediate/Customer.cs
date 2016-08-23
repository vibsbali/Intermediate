﻿using System.Collections.Generic;

namespace Intermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }


        public Customer(int id) : this()
        {
            Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }
    }
}