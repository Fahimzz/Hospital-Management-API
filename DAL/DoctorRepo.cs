using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoctorRepo
    {
        static HMSEntities contex;

        static DoctorRepo()
        {
            contex = new HMSEntities();
        }

        public static void AddDoctor(Doctor r)
        {
            contex.Doctors.Add(r);
            contex.SaveChanges();
        }

        public static List<Doctor> GetAllDoctor()
        {
            var data = contex.Doctors.ToList();
            return data;
        }
        public static Doctor GetDoctorById(string Username)
        {
            return contex.Doctors.FirstOrDefault(e => e.Username == Username);
        }

        public static void DeleteDoctor(string id)
        {
            var l = contex.Doctors.FirstOrDefault(e => e.Username == id);
            contex.Doctors.Remove(l);
            contex.SaveChanges();
        }
        public static void EditDoctor(Doctor l)
        {
            var old = contex.Doctors.FirstOrDefault(e => e.Username == l.Username);
            contex.Entry(old).CurrentValues.SetValues(l);
            contex.SaveChanges();
        }
    }
}
