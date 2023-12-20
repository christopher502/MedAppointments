using MedAppointments.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAppointments.Models;

namespace MedAppointments.Services
{
    internal class StatusService
    {
        private DatabaseContext databaseContext;
        public StatusService()
        {
            this.databaseContext = new DatabaseContext();
        }

        public List<Status> GetAllStatusTypes()
        {
            return databaseContext.statuses.ToList();
        }
    }
}
