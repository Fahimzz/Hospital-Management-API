using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;

namespace HospitalManagementSystem.Controllers
{
    public class ReceptionisController : ApiController
    {
        [Route ("api/Receptionist/GetAll")]

        public List<ReceptionistModel> GetAllReceptionist()
        {
            return ReceptionisServie.GetAllReceptionist(); 
        }
        
        [Route ("api/Receptionist/{id}/GetReceptionistById")]
       
        public ReceptionistModel GetReceptionistById(string id)
        {
            return ReceptionisServie.GetReceptionistById(id);
        }
        [Route ("api/Receptionist/EditRecep")]
        public void Edit(ReceptionistModel id)
        {
            ReceptionisServie.EditRecep(id);
        }

        

    }
}
