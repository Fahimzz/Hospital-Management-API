using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppointmentRepo
    {
        static HMSEntities contex;
        static AppointmentRepo()
        {
            contex = new HMSEntities();
        }
        public static List<Appointment> GetAllAppointments()
        {
            var data = contex.Appointments.ToList();
            return data;
        }
        public static List<Appointment> GetAccepted(string Status)
        {
            return contex.Appointments.Where(e => e.Status.Contains(Status)).ToList();
        }

        public static List<Appointment> GetDoctor(string Doctor)
        {
            return contex.Appointments.Where(e => e.Doctors.Contains(Doctor)).ToList();
        }

        public static List<Appointment> GetPatient(string Patient)
        {
            return contex.Appointments.Where(e => e.Patients.Contains(Patient)).ToList();
        }
        public static void AddPending(Appointment l)
        {
            contex.Appointments.Add(l);
            contex.SaveChanges();
        }

        public static void AddAccepted(Appointment l)
        {
            var old = contex.Appointments.FirstOrDefault(e => e.Patients == l.Patients && e.Doctors == l.Doctors && e.Id == l.Id);
            contex.Entry(old).CurrentValues.SetValues(l);
            contex.SaveChanges();
            contex.SaveChanges();
        }
    }
    
}
