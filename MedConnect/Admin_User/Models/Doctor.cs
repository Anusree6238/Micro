namespace Admin_User.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string? DoctorName { get; set; }

        public char DoctorGender { get; set; }

        public long DoctorPhoneNumber { get; set; }

        public string? DoctorEmail { get; set; }

        public string? DoctorSpecialization { get; set; }

        public int DoctorExperience { get; set; }

        public string? TimeSlot { get; set; }
    }
}
