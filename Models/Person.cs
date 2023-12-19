using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Models
{
    internal class Person
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string ContactNumber { get; set; }
        private Gender Gender { get; set; }
        private DateTime BirthDate { get; set; }

        public Person() { }
        public Person(int Id, string Name, string Surname, string ContactNumber, Gender Gender, DateTime BirthDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.ContactNumber = ContactNumber;
            this.Gender = Gender;
            this.BirthDate = BirthDate;
        }
    }
}
