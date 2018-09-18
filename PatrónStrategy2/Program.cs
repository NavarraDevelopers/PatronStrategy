using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrónStrategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fútbol
            // Defensiva y ataque
            // Patrón de estrategia

            var ataque = new EstrategiaAtaque();
            var defensa = new EstrategiaDefensa();
            var context = new Contexto(defensa); // Por defecto

            context.Accion();

            string option = "0";
            while (option != "3")
            {                
                Console.WriteLine("¿Qué estreategia quieres?");
                Console.WriteLine("1.- Atacar\n2.- Defender\n3.- Salir");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1": // Ataque
                        context.CambiarEstrategia(ataque);
                        context.Accion();
                        break;
                    case "2": // Defensa
                        context.CambiarEstrategia(defensa);
                        context.Accion();
                        break;
                    case "3": // Salir
                        Console.WriteLine("Fin del partido");                        
                        break;
                }                
            }

            Console.ReadLine();
        }
    }
}
