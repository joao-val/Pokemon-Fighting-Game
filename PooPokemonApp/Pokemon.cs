using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPokemonApp
{
    public class Pokemon
    {

        public Pokemon()
        {
            this.Name ="";
            this.Description ="";
        }

        public Pokemon(String name, String description)
        {
            this.Name = name;
            this.Description = description;
        }

        private String name;

        public String Name
        {
            get { return name; }
            set 
            {
                String text = value.ToUpper();
                name = text; 
            }
        }

        private String description; //armazena o valor da propriedade Descrição

        public String Description //representa a caracteristica Descrição do meu Pokémon
        {
            get { return this.description; }
            set { this.description = value.ToUpper(); }
        }

        public void ShowPokemonData()
        {
            Console.WriteLine("Pokemon name: " + this.Name);
            Console.WriteLine("Pokemon description: " + this.Description + "");
        }
        public void ShowPokemonData(Boolean formatted)
        {
            if (formatted == true)
            {
                Console.WriteLine("Pokemon " + this.Name + ": " + this.Description.ToLower());
            }
            else
            {
                Console.WriteLine("Pokemon name: " + this.Name);
                Console.WriteLine("Pokemon description: " + this.Description);
            }
        }

    }
}
