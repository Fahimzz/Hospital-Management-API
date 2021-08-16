using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceptionisRepo
    {
        static HMSEntities contex;
        static ReceptionisRepo()
        {
            contex = new HMSEntities();
        }
        public static List<Receptionist> GetAllReceptionist()
        {
            var data = contex.Receptionists.ToList();
            return data;
        }
        public static Receptionist GetReceptionistById (string Username)
        {
            return contex.Receptionists.FirstOrDefault(e => e.Username == Username);
        }

        public static void DeleteRecep(string id)
        {
            var l = contex.Receptionists.FirstOrDefault(e => e.Username == id);
            contex.Receptionists.Remove(l);
            contex.SaveChanges();
        }

        public static void AddRecep(Receptionist r)
        {
            contex.Receptionists.Add(r);
            contex.SaveChanges();
        }

        public static void EditRecep(Receptionist l)
        {
            var old = contex.Receptionists.FirstOrDefault(e => e.Username == l.Username);
            contex.Entry(old).CurrentValues.SetValues(l);
            contex.SaveChanges();
        }
    }
}
