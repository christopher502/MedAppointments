using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;
namespace MedAppointments.Services
{
    internal class VisitService
    {
        private AppointmentsContext databaseContext;
        public VisitService()
        {
            this.databaseContext = new AppointmentsContext();
        }

        public List<Visit> GetAllVisitTypes()
        {
            return databaseContext.visits.ToList();
        }
    }
}
