using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MedAppointments.Data.DatabaseContext;
using Microsoft.IdentityModel.Tokens;

namespace MedAppointments.Util
{
    public class Utils
    {
        public static Boolean ValidatePatientInputs(string name, string surname, string contactnumber, DateTime birthdate)
        {
            if (name.IsNullOrEmpty() || surname.IsNullOrEmpty() || contactnumber.IsNullOrEmpty())
            {
                MessageBox.Show("All fields are required. Please make sure you filled them all");
                return false;
            }

            if (birthdate > DateTime.Now)
            {
                MessageBox.Show("Birth date cannot be in the future. Please make sure you entered it correctly!");
                return false;
            }

            string pattern = @"^\+40";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(contactnumber))
            {
                MessageBox.Show("Phone number should start with +40");
                return false;
            }
            return true;
        }
    }
}
