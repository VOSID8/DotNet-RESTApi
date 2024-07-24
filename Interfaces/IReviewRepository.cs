using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        //here we define the methods that we want to implement in the ReviewRepository class
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        object GetReviewsOfAPokemon(int pokeId);
        bool DeleteReviews(List<Review> reviewsToDelete);
        bool CreateReview(Review reviewMap);
        bool UpdateReview(Review reviewMap);
        bool DeleteReview(Review reviewToDelete);
    }
}
