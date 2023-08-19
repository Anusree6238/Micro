using Microsoft.EntityFrameworkCore;
using User_Rating.Models;


namespace User_Rating.Data
{
    public class DbContextClass: DbContext
    {

        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("RatingAndReview"));
        }

        public DbSet<UserRating> UserRatings { get; set; }
    }
}
