using Appointment.Model;

namespace Appointment.Service
{
    public interface IAppointment
    {
        public IEnumerable<Appointment_Booking> ViewAllAppointments();
        public Appointment_Booking GetAppointmentByAppId(int id);
        public Appointment_Booking TakeAppointment(Appointment_Booking appointment);
        public Appointment_Booking ApproveAppointment(Appointment_Booking appointment);
    }
}
