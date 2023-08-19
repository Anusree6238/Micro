using Admin_User.Models;

using Admin_User.Services;

using Microsoft.AspNetCore.Mvc;

namespace Admin_User.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class DoctorsController : ControllerBase

    {

        private readonly IDoctorService doctorService;

        public DoctorsController(IDoctorService _doctorService)

        {

            doctorService = _doctorService;

        }

        [HttpGet]

        public IEnumerable<Doctor> DoctorList()

        {

            var doctorList = doctorService.GetDoctorList();

            return doctorList;

        }

        [HttpGet("{id}")]

        public Doctor GetDoctorById(int id)

        {

            return doctorService.GetDoctorById(id);

        }

        [HttpPost]

        public Doctor AddDoctor(Doctor doctor)

        {

            return doctorService.AddDoctor(doctor);

        }

        [HttpPut]

        public Doctor UpdateDoctor(Doctor doctor)

        {

            return doctorService.UpdateDoctor(doctor);

        }

        [HttpDelete("{id}")]

        public bool DeleteDoctor(int id)

        {

            return doctorService.DeleteDoctor(id);

        }

    }

}









