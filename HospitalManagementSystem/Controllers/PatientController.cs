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
        [Route("api/patient/all")]
        public List<string> GetAll()
        {
            return null;
        }
    }
}
