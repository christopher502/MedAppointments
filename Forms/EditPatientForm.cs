using MedAppointments.Data.Entities;
using MedAppointments.Enums;
using MedAppointments.Services;
using MedAppointments.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAppointments.Forms
{
    public partial class EditPatientForm : Form
    {
        private PatientService patientService;
        private int patientid;
        private string name;
        private string surname;
        private string contactnumber;
        private DateTime birthdate;
        private Gender gender;

        public EditPatientForm(int patientid)
        {
            this.patientService = new PatientService();
            this.patientid = patientid;
            InitializeComponent();
            FillPatientDetails();
        }

        public void FillPatientDetails()
        {
            Patient patient = patientService.GetPatientById(patientid);
            this.nameInput.Text = name = patient.name;
            this.surnameInput.Text = surname = patient.surname;
            this.numberInput.Text = contactnumber = patient.contactnumber;
            this.birthDatePicker.Value = this.birthdate = patient.birthdate;

            this.genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            this.genderComboBox.SelectedItem = gender = patient.gender;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = this.nameInput.Text;
            string surname = this.surnameInput.Text;
            string contactnumber = this.numberInput.Text;
            DateTime birthdate = birthDatePicker.Value;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString());

            if (Utils.ValidatePatientInputs(name, surname, contactnumber, birthdate))
            {
                if (!this.name.Equals(name) || !this.surname.Equals(surname) || !this.contactnumber.Equals(contactnumber) || !this.gender.Equals(gender) 
                    || (this.birthdate == birthdate) == false)
                {
                    Patient patient = patientService.UpdatePatient(patientid, name, surname, birthdate, contactnumber, gender);
                    string notification = (patient == null) ? "Could not update profile due to database issues. Please try again later or contact the administrator!"
                            : "Patient profile was successfully updated.";

                    this.Close();
                    MessageBox.Show(notification);
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
