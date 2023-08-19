using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Model
{
    public class Appointment_Booking
    {
        [Key]
        public int AppointmentId { get; set; }
        public int Doctor_id { get; set; }
        public string Department { get; set; }
        public DateFormat DateAndTime { get; set; }
        
        public string App_Status { get; set; }
    }
}
