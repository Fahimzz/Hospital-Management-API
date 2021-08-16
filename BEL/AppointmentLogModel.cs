using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AppointmentLogModel
    {
        public int Id { get; set; }
        public string PatientID { get; set; }
        public string DoctorID { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
    }
}
