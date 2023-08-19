using Appointment.Model;
using Appointment.Service;
using Microsoft.AspNetCore.Mvc;

namespace Appointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointment appointmentService;
        public AppointmentController(IAppointment _appointmentService)
        {
            appointmentService = _appointmentService;
        }


        [HttpGet("{Admin View Appointments}")]
        public IEnumerable<Appointment_Booking> ViewAllAppointments()
        {
            var appointmentList = appointmentService.ViewAllAppointments();
            return appointmentList;
        }
        [HttpGet("{ViewAppointmentsbyId}")]
        public Appointment_Booking GetAppointmentByAppId(int id)
        {
            return appointmentService.GetAppointmentByAppId(id);
        }

        [HttpPost("{Take Appointment}")]
        public Appointment_Booking TakeAppointment(Appointment_Booking appointment)
        {
            return appointmentService.TakeAppointment(appointment);
        }

        [HttpPut("{Approve Appointment}")]
        public Appointment_Booking ApproveAppointment(Appointment_Booking appointment)
        {
            return appointmentService.ApproveAppointment(appointment);
        }
    }
}
