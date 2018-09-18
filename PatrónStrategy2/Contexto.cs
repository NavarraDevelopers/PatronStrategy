using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrónStrategy2
{
    public class Contexto
    {
        private IStrategyAction _strategy;
        public Contexto(IStrategyAction strategy)
        {
            _strategy = strategy;
        }

        public void Accion()
        {
            _strategy.Accion();
        }

        public void CambiarEstrategia(IStrategyAction strategy)
        {
            _strategy = strategy;
        }
    }
}
