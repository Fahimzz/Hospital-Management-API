using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace HospitalManagementSystem.Controllers
{
    public class RegistrationController : ApiController
    {
        [Route("api/Registration/Add")]

        public void AddUSer(UserModel u)
        {
            LoginService.AddUser(u);
        }
        
    }
}
