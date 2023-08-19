using User_Rating.Models;

namespace User_Rating.Services
{
    public interface IRatingService
    {
        public IEnumerable<UserRating> GetRatingList();
       
        public UserRating AddRating(UserRating rating);
        
    }
}
