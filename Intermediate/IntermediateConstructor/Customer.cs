using System.Collections.Generic;

namespace IntermediateConstructor
{
    public class Customer
    {
        public string Name;
        public int Id;
        public List<Order> Orders;
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(string name) : this()
        {
            this.Name = name;
        }

        public Customer(int id, string name) : this(name)
        {
            this.Id = id;
        }
    }
}
