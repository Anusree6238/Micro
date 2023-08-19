using Appointment.Data;
using Appointment.Model;

namespace Appointment.Service
{
    public class AppointmentService:IAppointment
    { 

    
        private readonly DBContext _dbContext;

        public AppointmentService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Appointment_Booking> ViewAllAppointments()
        {
            return _dbContext.Appointments.ToList();
        }
        public Appointment_Booking GetAppointmentByAppId(int id)
        {
            return _dbContext.Appointments.Where(x => x.AppointmentId == id).FirstOrDefault();
        }

        public Appointment_Booking TakeAppointment(Appointment_Booking appointment)
        {
            var result = _dbContext.Appointments.Add(appointment);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Appointment_Booking ApproveAppointment(Appointment_Booking appointment)
        {
            var result = _dbContext.Appointments.Update(appointment);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}