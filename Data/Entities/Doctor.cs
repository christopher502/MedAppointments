using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Data.Entities
{
    public class Doctor : Person
    {
        public string username { get; set; }
        public string password { get; set; }
        public string speciality { get; set; }
    }
}
