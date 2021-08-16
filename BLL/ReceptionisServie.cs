using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class ReceptionisServie
    {
        public static List<ReceptionistModel> GetAllReceptionist()
        {
            var d = ReceptionisRepo.GetAllReceptionist();
            
            //var r = AutoMapper.Mapper.Map<List<Receptionist>, List<ReceptionistModel>>(data);
            List<ReceptionistModel> data = new List<ReceptionistModel>();
            foreach(var r in d)
            {

                var m = new ReceptionistModel()
                {
                    Username = r.Username,
                    Rname = r.Rname,
                    Age = r.Age,
                    Mobile = r.Mobile,
                    Gender=r.Gender,
                    Address=r.Address


                };
                data.Add(m);
            }

            return data;
        }

        

        public static void EditRecep(ReceptionistModel u)
        {
            var l = new Receptionist { Username = u.Username, Rname = u.Rname, Age = u.Age, Mobile = u.Mobile, Gender = u.Gender, Address = u.Address };
            ReceptionisRepo.EditRecep(l);
        }

        public static ReceptionistModel GetReceptionistById(string username)
        {
            var d = ReceptionisRepo.GetReceptionistById(username);
            
            var m = new ReceptionistModel()
            {
                Username = d.Username,
                Rname = d.Rname,
                Age = d.Age,
                Mobile = d.Mobile,
                Gender = d.Gender,
                Address = d.Address
            };
            
            return m;

        }
    }
}
