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
    public class AppointmentController : ApiController
    {
        [Route("api/Appointment/GetAll")]

        public List<AppointmentModel> GetAllAppointment()
        {
            return AppointmentService.GetAllAppointment();
        }
        [Route("api/AppointmentLog/GetAll")]
        public List<AppointmentLogModel> GetAllAppointmentLog()
        {
            return AppointmentLogService.GetAllAppointmentLogs();
        }

        [Route("api/Appointment/{Status}/GetStatusWiseData")]

        public List<AppointmentModel> GetAccepted(string Status)
        {
            return AppointmentService.GetAccepted(Status);
        }

        [Route("api/Appointment/{Doctor},{Status}/GetDoctorWiseData")]

        public List<AppointmentModel> GetDoctor(string Doctor, string Status)
        {
            return AppointmentService.GetDoctor(Doctor,Status);
        }

        [Route("api/Appointment/{Patient}/GetPatientWiseData")]

        public List<AppointmentModel> GetPatient(string Patient)
        {
            return AppointmentService.GetPatient(Patient);
        }

        [Route ("api/Appointment/{Patient},{Doctor}/Request")]
        public void AppoinmentAdd(string Patient,string Doctor)
        {
            AppointmentService.AddPending(Patient, Doctor);

        }

        [Route("api/Appointment/{Patient},{Doctor},{Id}/Accept")]
        public void AppoinmentAccept(string Patient, string Doctor,int Id)
        {
            AppointmentService.AddAccepted(Patient, Doctor,Id);

        }
        [Route("api/Appointment/{Patient},{Doctor},{Id}/Done")]
        public void AppoinmentDone(string Patient, string Doctor, int Id)
        {
            AppointmentService.AddDone(Patient, Doctor, Id);

        }

    }



}
