using Appointment.Model;
using Microsoft.EntityFrameworkCore;

namespace Appointment.Data
{
    public class DBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("Appointmentbooking"));
        }

        public DbSet<Appointment_Booking> Appointments { get; set; }
    }
}