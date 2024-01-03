using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Data.Entities
{
    public class Appointment
    {
        [Key]
        public int id { get; set; }

        [Column("patientid")]
        public int patientid { get; set; }

        [Column("visitid")]
        public int visitid { get; set; }

        [Column("statusid")]
        public int statusid { get; set; }

        [Column("appointmentdate")]
        public DateTime appointmentdate { get; set; }

        [Column("appointmenttime")]
        public TimeSpan appointmenttime { get; set; }

        [Column("createdat")]
        public DateTime createdat { get; set; }

        [Column("doctorid")]
        public int doctorid { get; set; }


        // Navigation properties
        public virtual Patient patient { get; set; }
        public virtual Visit visit { get; set; }
        public virtual Status status { get; set; }
        public virtual Doctor doctor { get; set; }
    }
}
