using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Repository 
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
            //here we are returning a pokemon by its id
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
            //here we are returning a pokemon by its name
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review =  _context.Reviews.Where(r => r.Id == pokeId);
            //here we are returning the average rating of a pokemon by its id
            if(review.Count() <= 0)
            {
                return 0;
            }
            return ((decimal)review.Sum(review => review.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
            //here we are returning a list of pokemons ordered by their id
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemon.Any(p => p.Id == pokeId);
            //here we are checking if a pokemon exists by its id
        }
        //ICollection is an interface that represents a collection of objects that can be individually accessed by index
    }
}
