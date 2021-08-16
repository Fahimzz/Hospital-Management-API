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
    public class LoginController : ApiController
    {
        [Route("api/Login/{id}")]
        public LoginModel GetLogin(string id)
        {
            return LoginService.GetLoginDetails(id);
        }
        [Route("api/Login/{id}/Delete")]
        public void Delete(string id)
        {
            LoginService.DeleteUser(id);
        }
    }
}
