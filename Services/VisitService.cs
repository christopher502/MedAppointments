using MedAppointments.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAppointments.Models;
namespace MedAppointments.Services
{
    internal class VisitService
    {
        private DatabaseContext databaseContext;
        public VisitService()
        {
            this.databaseContext = new DatabaseContext();
        }

        public List<Visit> GetAllVisitTypes()
        {
            return databaseContext.visits.ToList();
        }
    }
}
