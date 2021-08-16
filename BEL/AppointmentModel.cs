using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public string Doctors { get; set; }
        public string Patients { get; set; }
        public string Status { get; set; }
    }
}
