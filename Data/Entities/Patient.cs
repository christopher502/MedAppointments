using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace MedAppointments.Data.Entities
{
    public class Patient : Person
    {
        [Column("visits")]
        public int visits { get; set; }

        [Column("active")]
        public Boolean active { get; set; }
        public ICollection<Appointment> appointments { get; set; }

        public override string ToString()
        {
            return $"{name} {surname}";
        }
        public string DisplayFullName => $"{name} {surname}";

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Patient otherPatient = (Patient)obj;
            return id == otherPatient.id;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
