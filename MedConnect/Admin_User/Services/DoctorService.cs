using Admin_User.Data;

using Admin_User.Models;

namespace Admin_User.Services

{

    public class DoctorService : IDoctorService

    {

        private readonly DbContextClass _dbContext;

        public DoctorService(DbContextClass dbContext)

        {

            _dbContext = dbContext;

        }

        public IEnumerable<Doctor> GetDoctorList()

        {

            return _dbContext.Doctors.ToList();

        }

        public Doctor GetDoctorById(int id)

        {

            return _dbContext.Doctors.Where(x => x.DoctorId == id).FirstOrDefault();

        }

        public Doctor AddDoctor(Doctor doctor)

        {

            var result = _dbContext.Doctors.Add(doctor);

            _dbContext.SaveChanges();

            return result.Entity;

        }

        public Doctor UpdateDoctor(Doctor doctor)

        {

            var result = _dbContext.Doctors.Update(doctor);

            _dbContext.SaveChanges();

            return result.Entity;

        }

        public bool DeleteDoctor(int Id)

        {

            var filteredData = _dbContext.Doctors.Where(x => x.DoctorId == Id).FirstOrDefault();

            var result = _dbContext.Remove(filteredData);

            _dbContext.SaveChanges();

            return result != null ? true : false;

        }

    }

}