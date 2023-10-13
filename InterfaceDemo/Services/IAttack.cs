using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Services
{
    internal interface IAttack
    {
        void Attack(IPokemon target);
    }
}
