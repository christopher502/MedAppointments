using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Models
{
    internal class Doctor : Person
    {
        
        private String Speciality {  get; set; }
        public Doctor() : base() { }
        public Doctor(int Id, string Name, string Surname, string ContactNumber, Gender Gender, DateTime BirthDate, string Speciality)
            : base(Id, Name, Surname, ContactNumber, Gender, BirthDate)
        {
            this.Speciality = Speciality;
        }
    }
}
