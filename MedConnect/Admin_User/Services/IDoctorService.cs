using Admin_User.Models;
namespace Admin_User.Services

{
    public interface IDoctorService
    {
        public IEnumerable<Doctor> GetDoctorList();

        public Doctor GetDoctorById(int id);

        public Doctor AddDoctor(Doctor doctor);

        public Doctor UpdateDoctor(Doctor doctor);

        public bool DeleteDoctor(int Id);

    }

}

