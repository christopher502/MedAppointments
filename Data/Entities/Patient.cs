using MedAppointments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedAppointments.Data.Entities
{
    public class Patient : Person
    {
        public int visits { get; set; }
        public ICollection<Appointment> appointments { get; set; }
    }
}
