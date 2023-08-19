using Admin_User.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Admin_User.Data
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

            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

        }

        public DbSet<Doctor> Doctors { get; set; }

    }
}
