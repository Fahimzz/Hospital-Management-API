using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginRepo
    {
        static HMSEntities contex;
        static LoginRepo()
        {
            contex = new HMSEntities();
        }
        public static Login GetLoginDetails(string Username)
        {
            return contex.Logins.FirstOrDefault(e => e.Username == Username);
        }
        public static void AddUser(Login l)
        {
            contex.Logins.Add(l);
            contex.SaveChanges();
        }

        public static void DeleteUser(string id)
        {
            var l = contex.Logins.FirstOrDefault(e => e.Username == id);
            contex.Logins.Remove(l);
            contex.SaveChanges();
        }
    }
    
}
