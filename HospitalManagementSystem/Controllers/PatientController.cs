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
    public class PatientController : ApiController
    {
        [Route("api/Patient/GetAll")]

        public List<PatientModel> GetAllPatient()
        {
            return PatientService.GetAllPatient();
        }

        [Route("api/Patient/{id}")]

        public PatientModel GetPatientById(string id)
        {
            return PatientService.GetPatientById(id);
        }
       [Route("api/Patient/EditPatient")]
        public void Edit(PatientModel id)
        {
            PatientService.EditPatient(id);
        }
        [Route("api/Patient/{id}/Delete")]
        public void Delete(string id)
        {
            PatientService.DeletePatient(id);
        }

        [Route("api/Patient/GetAllLog")]

        public List<PatientLogModel> GetAllPatientLog()
        {
            return PatientService.GetAllPatientLog();
        }
    }
}
