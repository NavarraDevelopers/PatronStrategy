using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrónStrategy2
{
    public class EstrategiaDefensa : IStrategyAction
    {
        public void Accion()
        {
            Console.WriteLine("¡Defended! ¡nos atacan!\n");
        }
    }
}
