using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPokemonApp
{
    public class Pokedex
    {

        private List<PokemonPlus> pokemons;

        public Pokedex()
        {
            this.InitializeList();
        }

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void Show()
        {
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("\nPokemon -- Battle game");
            Console.WriteLine("0 - Exit game");
            Console.WriteLine("1 - List all pokemons in pokedex");
            Console.WriteLine("2 - Battle");

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
                    case 1:
                    {
                        ListPokemons();
                        Console.ReadKey();
                        Console.Clear();
                        Show();
                        break;
                    }
                    case 2:
                    {
                        Battle();
                        Console.ReadKey();
                        Console.Clear();
                        Show();
                        break;
                    }

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
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasaur", "Grass type pokemon", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "Psychic legendary pokemon", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Psychic legendary pokemon", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "Ghost legendary pokemon", 95);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flygon", "Dragon type pokemon", 55);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "Toxic type pokemon", 11);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "Steel type pokemon", 50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pikachu", "Eletric type pokemon", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Entei", "Fire legendary pokemon", 165);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lucario", "Fighter and steel type pokemon", 65);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mudkip", "Water type pokemon", 35);
            this.pokemons.Add(p);
            p = new PokemonPlus("Paras", "Insect type pokemon", 33);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kyogre", "Water legendary pokemon", 89);
            this.pokemons.Add(p);
        }

        private void ListPokemons()
        {
            Console.Clear();
            Console.WriteLine("Pokemons list:\n");
            for(int i = 0; i < this.pokemons.Count; i++)
            {
                Console.WriteLine("Pokemon code: " + i);
                this.Pokemons[i].ShowPokemonData();
                //Pokemon p = this.pokemons[i];
                //p.ShowPokemonData();
                Console.WriteLine("-----------------------------------");
            }
        }

        private void Battle()
        {
            ListPokemons();
            Console.WriteLine("Enter pokemon code: ");
            var code = Convert.ToInt32(Console.ReadLine());
            //pegar o pokemon do player
            var pPlayer = this.Pokemons[code];
            Console.WriteLine("You chose: " + pPlayer.Name);
            //definir o pokemon do pc
            Random r = new Random();
            code = r.Next(0, Pokemons.Count);
            var pPC = this.Pokemons[code];
            Console.WriteLine("\nPC chose: " + pPC.Name);
            //batalhar
            if (pPlayer.Power >= pPC.Power)
            {
                Console.Clear();
                Console.WriteLine("\nCongratulations!!! You win");
                Console.WriteLine("Your pokemon is stronger than your opponent's pokemon. " + "\nYour choice:");
                pPlayer.ShowPokemonDataPlus();
                Console.WriteLine("\nThe opponent choose: ");
                pPC.ShowPokemonDataPlus();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("What a sadness!!! You lose");
                Console.WriteLine("Your pokemon is weaker than your opponent's pokemon. " + "\nYour choice:");
                pPlayer.ShowPokemonDataPlus();
                Console.WriteLine("\nThe opponent choose: ");
                pPC.ShowPokemonDataPlus();
            }
        }


    }
}
