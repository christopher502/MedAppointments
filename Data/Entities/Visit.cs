using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAppointments.Data.Entities
{
    public class Visit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Appointment> appointments { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Visit otherVisit = (Visit)obj;
            return id == otherVisit.id;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
