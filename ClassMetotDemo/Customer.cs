using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }
}
