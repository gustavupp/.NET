using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Order
    {
        public Order()
        {
        }
    }
    internal class Costumer
    {
        public int Id;
        public string Name;
        public List<Order> myOrder;

        //first contructor
        public Costumer()
        {
            myOrder = new List<Order>(); //aways initialize a new List!!
        }

        //second
        public Costumer(int id)
            : this() //pass the execution to the previous constructor
        {
            this.Id = id;
        }

        //third
        public Costumer(string name, int id)
            : this(id)
        {
            this.Name = name;
        }

    }
}
