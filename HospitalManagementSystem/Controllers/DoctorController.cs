using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HospitalManagementSystem.Controllers
{
    public class DoctorController : ApiController
    {
        [Route("api/Doctor/GetAll")]

        public List<DoctorModel> GetAllDoctor()
        {
            return DoctorService.GetAllDoctor();
        }

        [Route("api/Doctor/{id}/GetDoctorById")]

        public DoctorModel GetDoctorById(string id)
        {
            return DoctorService.GetDoctorById(id);
        }
        [Route("api/Doctor/EditDoctor")]
        public void Edit(DoctorModel id)
        {
            DoctorService.EditDoctor(id);
        }

        [Route("api/Doctor/{id}/Delete")]
        public void Delete(string id)
        {
            DoctorService.DeleteDoctor(id);
        }
    }
}
