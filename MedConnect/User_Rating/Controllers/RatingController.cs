using Microsoft.AspNetCore.Mvc;
using User_Rating.Models;
using User_Rating.Services;

namespace User_Rating.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService ratingService;
        public RatingController(IRatingService _ratingService)
        {
            ratingService = _ratingService;
        }
        [HttpGet("{GetAll the rating}")]
        public IEnumerable<UserRating> RatingList()
        {
            var ratingList = ratingService.GetRatingList();
            return ratingList;
        }
        [HttpPost("{Add your Rating And Review")]
        public UserRating AddRating(UserRating rating)
        {
            return ratingService.AddRating(rating);
        }
    }
}
