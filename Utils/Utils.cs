using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAppointments.Data.DatabaseContext;

namespace MedAppointments.Utils
{
    public class Utils
    {
        public static void CommitDatabaseChanges()
        {
            try
            {
                using (var context = new AppointmentsContext())
                {
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception("Unable to save data into database. Please try again later, or contact the administrator!");
            }
        }
    }
}
