using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Services
{
    internal interface IPokemon
    {
        string Name { get; }
        string Type { get; }
        int Health { get; set; }
        void Display();
    }


}
