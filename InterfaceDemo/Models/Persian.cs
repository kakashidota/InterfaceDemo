using InterfaceDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Models
{
    internal class Persian : IPokemon
    {
        public string Name { get; }

        public string Type { get; }

        public int Health { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} is meowing");
        }
    }
}
