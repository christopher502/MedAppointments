﻿using System;
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
using MedAppointments.Data.Entities;

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
            Gender gender = Gender.Male;

            Patient? patient = patientService.AddPatient(name, surname, contactnumber, gender, birthdate);
            
            if (patient == null)
            {
                this.Close();
                MessageBox.Show("Could not add new patient due to database issues. Please try again later or contact the administrator!");
            } else
            {
                this.Close();
                MessageBox.Show("Patinet '" + patient.name + " " + patient.surname + "' was successfully added.");
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}