using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Models
{
    public class Appointment
    {
        [Key]
        public int id { get; set; }
        public int patientid { get; set; }
        public int visitid { get; set; }
        public int statusid { get; set; }

        public DateTime date { get; set; }

        // Navigation properties
        public virtual Patient patient { get; set; }
        public virtual Visit visit { get; set; }
        public virtual Status status { get; set; }
    }
}
