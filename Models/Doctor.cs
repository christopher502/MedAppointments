using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Models
{
    public class Doctor : Person
    {
        public String username { get; set; }
        public String password { get; set; }
        public String speciality {  get; set; }
    }
}
