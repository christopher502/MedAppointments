using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.Enums;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;

namespace MedAppointments.Services
{
    internal class PatientService
    {
        private AppointmentsContext databaseContext;
        public PatientService()
        {
            this.databaseContext = new AppointmentsContext();
        }
        
        public List<Patient> GetAllPatients()
        {
            return databaseContext.patients.ToList();
        }
    }
}
