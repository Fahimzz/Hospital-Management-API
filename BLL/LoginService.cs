using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
namespace BLL
{
    public class LoginService
    {
        public static LoginModel GetLoginDetails(string username)
        {
            var d = LoginRepo.GetLoginDetails(username);

            var m = new LoginModel()
            {
                Username = d.Username,
                Password = d.Password,
                Type = d.Type
               
            };

            return m;

        }

        public static void DeleteUser(string id)
        {
            ReceptionisRepo.DeleteRecep(id);
            LoginRepo.DeleteUser(id);
        }

        public static void AddUser(UserModel u)
        {
            
            var a = new Login { Username= u.Username,Password=u.Password,Type=u.Type };
            LoginRepo.AddUser(a);

            if (u.Type == "Receptionist") { 
            var l = new Receptionist { Username = u.Username, Rname = u.Rname, Age = u.Age, Mobile = u.Mobile, Gender = u.Gender, Address = u.Address };
            
            ReceptionisRepo.AddRecep(l);
            }
            else if(u.Type=="Patient")
            {
                var l = new Patient { Username = u.Username, Pname = u.Pname, Age = u.Age, Mobile = u.Mobile, Gender = u.Gender, Address = u.Address };
                PatientRepo.AddPatient(l);

            }
            else if(u.Type=="Doctor")
            {
                var l = new Doctor { Username = u.Username, Dname = u.Dname, Age = u.Age, Mobile = u.Mobile, Gender = u.Gender, Address = u.Address };
                DoctorRepo.AddDoctor(l);
            }
        }

    }
}
