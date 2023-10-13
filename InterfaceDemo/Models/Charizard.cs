using InterfaceDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Models
{
    internal class Charizard : IPokemon, IAttack, ITrain
    {
        public string Name { get; }

        public string Type { get; }

        public int Health { get; set; } = 100;

        public Charizard(string name)
        {
            Name = name;
        }

        public void Attack(IPokemon target)
        {
            Console.WriteLine($"{Name} is attacking {target.Name}");
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is of type {Type}");
        }

        public void Train()
        {
            Console.WriteLine($"{Name} is training hard!");
        }
    }
}
