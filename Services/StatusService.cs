using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;

namespace MedAppointments.Services
{
    internal class StatusService
    {
        private AppointmentsContext databaseContext;
        public StatusService()
        {
            this.databaseContext = new AppointmentsContext();
        }

        public List<Status> GetAllStatusTypes()
        {
            return databaseContext.statuses.ToList();
        }
    }
}
