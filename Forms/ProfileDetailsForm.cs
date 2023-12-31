﻿using MedAppointments.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAppointments.Services;
using MedAppointments.Util;
using MedAppointments.Enums;
using MedAppointments.Forms;

namespace MedAppointments
{
    public partial class ProfileDetailsForm : Form
    {
        private DoctorService doctorService;
        private int doctorId;
        private string name { get; set; }
        private string surname { get; set; }
        private string contactnumber { get; set; }
        private string speciality { get; set; }
        private Gender gender { get; set; }
        private DateTime birthdate { get; set; }

        public ProfileDetailsForm(int doctorId)
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
            this.doctorId = doctorId;

            FillProfileInputs();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            string name = this.nameInput.Text;
            string surname = this.surnameInput.Text;
            string contactnumber = this.numberInput.Text;
            string speciality = this.specialityInput.Text;
            DateTime birthdate = birthDatePicker.Value;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString());

            if (Utils.ValidateProfileInputs(name, surname, contactnumber, birthdate, speciality))
            {
                if (!this.name.Equals(name) || !this.surname.Equals(surname) || !this.contactnumber.Equals(contactnumber) || !this.speciality.Equals(speciality)
                    || !this.gender.Equals(gender) || (this.birthdate == birthdate) == false)
                {
                    Doctor doctor = doctorService.UpdateDoctorProfile(1, name, surname, birthdate, contactnumber, gender, speciality);
                    string notification = (doctor == null) ? "Could not update profile due to database issues. Please try again later or contact the administrator!"
    : "Your profile was successfully updated.";

                    this.Close();
                    MessageBox.Show(notification);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillProfileInputs()
        {
            Doctor doctor = doctorService.GetDoctorById(doctorId);
            this.name = this.nameInput.Text = doctor.name;
            this.surname = this.surnameInput.Text = doctor.surname;
            this.contactnumber = this.numberInput.Text = doctor.contactnumber;
            this.speciality = this.specialityInput.Text = doctor.speciality;
            this.birthdate = this.birthDatePicker.Value = doctor.birthdate;
            this.genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            this.genderComboBox.SelectedItem = doctor.gender;
            this.gender = doctor.gender;
        }

        private void LogOutButonClick(object sender, EventArgs e)
        {
            this.Owner.Close();
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
