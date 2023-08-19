using Microsoft.EntityFrameworkCore;

using User_Registration.Models;

namespace User_Registration.Data

{

    public class DbContextClass : DbContext

    {

        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)

        {

            Configuration = configuration;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {

            options.UseSqlServer(Configuration.GetConnectionString("UserConnection"));

        }

        public DbSet<User_Reg> UserRegistrations { get; set; }

    }

}









