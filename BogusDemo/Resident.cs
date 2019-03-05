using System;
using System.Collections.Generic;
using System.Text;

namespace BogusDemo
{
    public class Resident
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Street { get; set; }
        public string Housenumber { get; set; }

        public string City { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name}\t{Street}\t{Housenumber}\t{City}\t{Id}");
        }
    }
}
