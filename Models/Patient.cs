using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Models
{
    internal class Patient : Person
    {
        private int Visits { get; set; }
        public Patient() : base() { }
        public Patient(int Id, string Name, string Surname, string ContactNumber, Gender Gender, DateTime BirthDate, int Visits)
            : base (Id, Name, Surname, ContactNumber, Gender, BirthDate)
        {
            this.Visits = Visits;
        }

    }
}
