using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System.Runtime.CompilerServices;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository, DataContext context)
        {
            _pokemonRepository = pokemonRepository;
        }

        //this is a constructor that takes in an IPokemonRepository and a DataContext

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Pokemon>))]

        //here we are getting a list of pokemons

        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemons);
        }
    }
}
