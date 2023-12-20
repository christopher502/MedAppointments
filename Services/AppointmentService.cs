using MedAppointments.Configuration;
using MedAppointments.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Services
{
    public class AppointmentService
    {
        private DatabaseContext databaseContext { get; set; }

        public AppointmentService()
        {
            this.databaseContext = new DatabaseContext();
        }

        public List<Appointment> GetAllAppointments()
        {
            return databaseContext.appointments
                    .Include(p => p.patient)
                    .Include(v => v.visit)
                    .Include(s => s.status)
                    .ToList();
        }
    }
}
