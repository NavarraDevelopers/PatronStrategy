using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrónStrategy2
{
    public class EstrategiaAtaque : IStrategyAction
    {
        public void Accion()
        {
            Console.WriteLine("¡A por ellos! ¡Atacad como nunca!\n");
        }
    }
}
