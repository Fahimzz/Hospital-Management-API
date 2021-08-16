using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DoctorService
    {
        public static List<DoctorModel> GetAllDoctor()
        {
            var d = DoctorRepo.GetAllDoctor();

            
            List<DoctorModel> data = new List<DoctorModel>();
            foreach (var r in d)
            {

                var m = new DoctorModel()
                {
                    Username = r.Username,
                    Dname = r.Dname,
                    Age = r.Age,
                    Mobile = r.Mobile,
                    Gender = r.Gender,
                    Address = r.Address


                };
                data.Add(m);
            }

            return data;
        }

        public static DoctorModel GetDoctorById(string username)
        {
            var d = DoctorRepo.GetDoctorById(username);

            var m = new DoctorModel()
            {
                Username = d.Username,
                Dname = d.Dname,
                Age = d.Age,
                Mobile = d.Mobile,
                Gender = d.Gender,
                Address = d.Address
            };

            return m;

        }

        public static void EditDoctor(DoctorModel u)
        {
            var l = new Doctor { Username = u.Username, Dname = u.Dname, Age = u.Age, Mobile = u.Mobile, Gender = u.Gender, Address = u.Address };
            DoctorRepo.EditDoctor(l);
        }

        public static void DeleteDoctor(string id)
        {
            DoctorRepo.DeleteDoctor(id);
            LoginRepo.DeleteUser(id);
        }
    }
}
