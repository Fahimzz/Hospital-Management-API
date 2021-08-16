using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class AppointmentLogService
    {
        public static List<AppointmentLogModel> GetAllAppointmentLogs()
        {

            var d = AppointmentLogRepo.GetAllAppointmentLog();

            //var r = AutoMapper.Mapper.Map<List<Receptionist>, List<ReceptionistModel>>(data);
            List<AppointmentLogModel> data = new List<AppointmentLogModel>();
            foreach (var r in d)
            {

                var m = new AppointmentLogModel()
                {
                    Id = r.Id,
                    PatientID=r.PatientID,
                    DoctorID=r.DoctorID,
                    Status=r.Status,
                    Time=r.Time



                };
                data.Add(m);
            }

            return data;
        }
    }
}
