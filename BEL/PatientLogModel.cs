using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PatientLogModel
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public string Time { get; set; }
        public string Operation { get; set; }
    }
}
