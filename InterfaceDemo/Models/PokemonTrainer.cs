using InterfaceDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Models
{
    internal class PokemonTrainer
    {
       private List<IPokemon> pokemonList = new List<IPokemon>();

        public void Catch(IPokemon pokemon)
        {
            pokemonList.Add(pokemon);
        }

        public void TrainPokemon(IPokemon pokemon)
        {
            if(pokemon is ITrain trainablePokemon)
            {
                trainablePokemon.Train();
            } else
            {
                Console.WriteLine($"The pokemon {pokemon.Name} is not trainable");
            }
        }

        public void PokemonBattle(IPokemon pokemon1, IPokemon pokemon2)
        {
            if(pokemon1 is IAttack attackingPokemon1 && pokemon2 is IAttack attackingPokemon2)
            {
                attackingPokemon1.Attack(pokemon2);
                attackingPokemon2.Attack(pokemon1);
            } else
            {
                Console.WriteLine("One of tthe pokemons is not a fighter");
            }
        }


        public void DisplayPokemon()
        {
            foreach (var pokemon in pokemonList)
            {
                pokemon.Display();
            }
        }

    }
}
