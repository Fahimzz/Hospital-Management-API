using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AppointmentLogRepo
    {
        static HMSEntities contex;
        static AppointmentLogRepo()
        {
            contex = new HMSEntities();
        }
        public static List<AppointmentLog> GetAllAppointmentLog()
        {
            var data = contex.AppointmentLogs.ToList();
            return data;
        }
    }
}
