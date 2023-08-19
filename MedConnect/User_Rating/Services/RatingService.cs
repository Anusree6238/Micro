using User_Rating.Data;
using User_Rating.Models;

namespace User_Rating.Services
{
    public class RatingService : IRatingService
    {

        private readonly DbContextClass _dbContext;

        public RatingService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<UserRating> GetRatingList()
        {
            return _dbContext.UserRatings.ToList();
        }

        public UserRating AddRating(UserRating rating)
        {
            var result = _dbContext.UserRatings.Add(rating);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}
