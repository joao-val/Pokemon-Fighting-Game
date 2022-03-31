using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPokemonApp
{
    public class Pokedex
    {

        private List<Pokemon> pokemons;

        public Pokedex()
        {
            this.InitializeList();
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        public void Show()
        {
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("\nPokedex----Pokemon schedule");
            Console.WriteLine("0 - Exit pokedex");
            Console.WriteLine("1 - List all pokemons");
            Console.Write("What do yout want to do? ");
            var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                    case 1: ListPokemons(); break;
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Option.");
                        Show();
                        break;
                    }
                }
        }
        private void InitializeList()
        {
            // Instanciar a lista
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbasaur", "Grass type pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "Psychic legendary pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwo", "Psychic legendary pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Giratina", "Ghost legendary pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Flyhon", "Your description");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "Your description");
            this.pokemons.Add(p);
            p = new Pokemon("Muk", "Your description");
            this.pokemons.Add(p);
            p = new Pokemon("Pikachu", "Eletric type pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Entei", "Fire legendary pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Lucario", "Fighter and steel type pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Mudkip", "Water type pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Paras", "Insect type pokemon");
            this.pokemons.Add(p);
            p = new Pokemon("Kyogre", "Water legendary pokemon");
            this.pokemons.Add(p);
        }

        public void ListPokemons()
        {
            Console.WriteLine("Pokemons list:\n");
            for(int i = 0; i < this.pokemons.Count; i++)
            {
                this.Pokemons[i].ShowPokemonData();
                //Pokemon p = this.pokemons[i];
                //p.ShowPokemonData();
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadKey();
            Console.Clear();
            Show();
        }


    }
}
