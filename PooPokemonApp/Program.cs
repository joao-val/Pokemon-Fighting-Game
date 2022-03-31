using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pokedex pokedex = new Pokedex();
            pokedex.Menu();
            Console.ReadKey();
        }
    }
}
