using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PatientRepo
    {
        static HMSEntities contex;

        static PatientRepo()
        {
            contex = new HMSEntities();
        }

        
       
            public static List<Patient> GetAllPatient()
            {
                var data = contex.Patients.ToList();
                return data;
            }
     

        public static void AddPatient(Patient r)
        {
            contex.Patients.Add(r);
            contex.SaveChanges();
        }

        public static Patient GetPatientById(string username)
        {
            return contex.Patients.FirstOrDefault(e => e.Username == username);
        }

        public static void EditPatient(Patient l)
        {
            var old = contex.Patients.FirstOrDefault(e => e.Username == l.Username);
            contex.Entry(old).CurrentValues.SetValues(l);
            contex.SaveChanges();
        }

        public static void DeletePatient(string id)
        {
            var l = contex.Patients.FirstOrDefault(e => e.Username == id);
            contex.Patients.Remove(l);
            contex.SaveChanges();
        }

        public static List<Patientlog> GetAllPatientLog()
        {
            var data = contex.Patientlogs.ToList();
            return data;
        }
    }
}
