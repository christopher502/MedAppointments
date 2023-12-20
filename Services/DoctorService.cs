using MedAppointments.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAppointments.Models;
namespace MedAppointments.Services
{
    internal class DoctorService
    {
        private DatabaseContext databaseContext;
        public DoctorService()
        {
            this.databaseContext = new DatabaseContext();
        }

        public List<Doctor> GetAllDoctors()
        {
            return databaseContext.doctors.ToList();
        }
    }
}
