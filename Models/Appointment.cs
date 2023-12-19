using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Models
{
    internal class Appointment
    {
        private Patient patient {  get; set; }
        private Visit visit { get; set; }
        private DateTime date { get; set; }
        private DateTime time { get; set; }
        private Status Status { get; set; }

        public Appointment() { }

        public Appointment(Patient patient, Visit visit, DateTime date, DateTime time, Status status)
        {
            this.patient = patient;
            this.visit = visit;
            this.date = date;
            this.time = time;
            Status = status;
        }
    }
}
