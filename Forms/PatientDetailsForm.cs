using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAppointments.Enums;
using MedAppointments.Services;
using MedAppointments.Util;
using MedAppointments.Data.Entities;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MedAppointments
{
    public partial class PatientDetailsForm : Form
    {
        private PatientService patientService;
        public PatientDetailsForm()
        {
            InitializeComponent();
            this.patientService = new PatientService();
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string surname = surnameInput.Text;
            string contactnumber = numberInput.Text;
            DateTime birthdate = birthDatePicker.Value;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString());

            if (Utils.ValidatePatientInputs(name,surname,contactnumber,birthdate))
            {
                Patient? patient = patientService.AddPatient(name, surname, contactnumber, gender, birthdate);
                
                string notification = (patient == null) ? "Could not add new patient due to database issues. Please try again later or contact the administrator!" 
                    : "Patinet '" + patient.name + " " + patient.surname + "' was successfully added.";

                this.Close();
                MessageBox.Show(notification);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
