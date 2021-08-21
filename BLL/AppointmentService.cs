using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class AppointmentService
    {
        public static List<AppointmentModel> GetAllAppointment()
        {

            var d = AppointmentRepo.GetAllAppointments();

            //var r = AutoMapper.Mapper.Map<List<Receptionist>, List<ReceptionistModel>>(data);
            List<AppointmentModel> data = new List<AppointmentModel>();
            foreach (var r in d)
            {

                var m = new AppointmentModel()
                {
                    Id= r.Id,
                    Doctors = r.Doctors,
                    Patients = r.Patients,
                    Status = r.Status
                    


                };
                data.Add(m);
            }

            return data;
        }

        public static List<AppointmentModel> GetAccepted(string Status)
        {
            var d = AppointmentRepo.GetAccepted(Status);
            List<AppointmentModel> data = new List<AppointmentModel>();
            foreach(var r in d) { 
            var m = new AppointmentModel()
            {
                Id= r.Id,
                Doctors=r.Doctors,
                Patients=r.Patients,
                Status=r.Status
            };
                data.Add(m);
            }

            return data;
        }

        public static List<AppointmentModel> GetDoctor(string Doctor,string Status)
        {
            var d = AppointmentRepo.GetDoctor(Doctor,Status);
            List<AppointmentModel> data = new List<AppointmentModel>();
            foreach (var r in d)
            {
                var m = new AppointmentModel()
                {
                    Id = r.Id,
                    Doctors = r.Doctors,
                    Patients = r.Patients,
                    Status = r.Status
                };
                data.Add(m);
            }

            return data;
        }

        public static List<AppointmentModel> GetPatient(string Patient)
        {
            var d = AppointmentRepo.GetPatient(Patient);
            List<AppointmentModel> data = new List<AppointmentModel>();
            foreach (var r in d)
            {
                var m = new AppointmentModel()
                {
                    Id = r.Id,
                    Doctors = r.Doctors,
                    Patients = r.Patients,
                    Status = r.Status
                };
                data.Add(m);
            }

            return data;
        }
        public static void AddPending(string Patient, string Doctor)
        {
            var a = new Appointment { Patients = Patient, Doctors = Doctor, Status = "Pending" };
            AppointmentRepo.AddPending(a);
        }

        public static void AddAccepted(string Patient, string Doctor,int Id)
        {
            var a = new Appointment { Patients = Patient, Doctors = Doctor, Status = "Accepted",Id=Id };
            AppointmentRepo.AddAccepted(a);
        }
        public static void AddDone(string Patient, string Doctor, int Id)
        {
            var a = new Appointment { Patients = Patient, Doctors = Doctor, Status = "Done", Id = Id };
            AppointmentRepo.AddDone(a);
        }
    }
}
