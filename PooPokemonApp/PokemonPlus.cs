using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPokemonApp
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            this.Power = 0;
        }

        public PokemonPlus(String name, String description, int power) : base(name, description)
        {
            this.Power = power;
        }

        public int Power { get; set; }

        public void ShowPokemonDataPlus()
        {
            Console.WriteLine("Pokemon name: " + this.Name);
            Console.WriteLine("Pokemon description: " + this.Description + "");
            Console.WriteLine("Power: " + this.Power);
        }
    }
}
