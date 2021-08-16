using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class PatientService
    {
        public static List<PatientModel> GetAllPatient()
        {
            var a = PatientRepo.GetAllPatient();
            List<PatientModel> data = new List<PatientModel>();
            foreach(var d in a)
            {
                var m = new PatientModel()
                {
                    Username = d.Username,
                    Pname=d.Pname,
                    Age=d.Age,
                    Address=d.Address,
                    Mobile=d.Mobile,
                    Gender=d.Gender

                };
                data.Add(m);
            }
            return data;
        }

        public static PatientModel GetPatientById(string username)
        {
            var d = PatientRepo.GetPatientById(username);

            var m = new PatientModel()
            {
                Username = d.Username ,
                Pname = d.Pname,
                Age = d.Age,
                Mobile = d.Mobile,
                Gender = d.Gender,
                Address = d.Address
            };

            return m;
        }
        public static void EditPatient(PatientModel u)
        {
            var l = new Patient { Username = u.Username, Pname = u.Pname, Age = u.Age, Mobile = u.Mobile, Gender = u.Gender, Address = u.Address };
            PatientRepo.EditPatient(l);
        }

        public static void DeletePatient(string id)
        {
            PatientRepo.DeletePatient(id);
            LoginRepo.DeleteUser(id);
        }

        public static List<PatientLogModel> GetAllPatientLog()
        {
            var a = PatientRepo.GetAllPatientLog();
            List<PatientLogModel> data = new List<PatientLogModel>();
            foreach (var d in a)
            {
                var m = new PatientLogModel()
                {
                    Id = d.Id,
                    PatientId=d.PatientId,
                    Operation=d.Operation,
                    Time=d.Time
                

                };
                data.Add(m);
            }
            return data;
        }
    }
}
