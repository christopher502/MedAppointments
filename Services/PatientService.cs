using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.Models;
using MedAppointments.Enums;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedAppointments.Configuration;

namespace MedAppointments.Services
{
    internal class PatientService
    {
        private DatabaseContext databaseContext;
        public PatientService()
        {
            this.databaseContext = new DatabaseContext();
        }
        
        public List<Patient> GetAllPatients()
        {
            return databaseContext.patients.ToList();
        }
    }
}
