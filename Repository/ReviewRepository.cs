using PokemonReviewApp.Models;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Data;
using AutoMapper;

namespace PokemonReviewApp.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CreateReview(Review reviewMap)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReview(Review reviewToDelete)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReviews(List<Review> reviewsToDelete)
        {
            throw new NotImplementedException();
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public object GetReviewsOfAPokemon(int pokeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Review> GetReviewsOfPokemon(int pokeId)
        {
            return _context.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.Id == reviewId);
        }

        public bool UpdateReview(Review reviewMap)
        {
            throw new NotImplementedException();
        }
    }
}
