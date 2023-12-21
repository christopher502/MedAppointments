using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;
using MedAppointments.Enums;

namespace MedAppointments.Services
{
    internal class DoctorService
    {
        private AppointmentsContext databaseContext;
        public DoctorService()
        {
            this.databaseContext = new AppointmentsContext();
        }

        public List<Doctor> GetAllDoctors()
        {
            return databaseContext.doctors.ToList();

        }
    }
}
