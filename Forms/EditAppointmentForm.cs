using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using MedAppointments.Data.Entities;
using MedAppointments.Services;
using MedAppointments.Util;

namespace MedAppointments.Forms
{
    public partial class EditAppointmentForm : Form
    {
        private AppointmentService appointmentService;
        private PatientService patientService;
        private VisitService visitService;
        private Doctor doctor;
        private StatusService statusService;
        private int appointmentId;

        private Patient patient { get; set; }
        private Visit visit { get; set; }
        private DateTime date { get; set; }
        private TimeSpan time { get; set; }
        private Status status { get; set; }

        public EditAppointmentForm(int appointmentId, Doctor doctor)
        {

            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.patientService = new PatientService();
            this.visitService = new VisitService();
            this.statusService = new StatusService();
            this.appointmentId = appointmentId;
            this.doctor = doctor;
            FillAppointmentDetails();
        }

        private void FillAppointmentDetails()
        {
            Appointment appointment = appointmentService.GetAppointmentById(appointmentId);
            this.patientComboBox.DataSource = patientService.GetAllPatientsByDoctor(doctor);
            this.patientComboBox.DisplayMember = "DisplayFullName";
            this.patientComboBox.ValueMember = "id";
            this.patientComboBox.SelectedItem = this.patient = appointment.patient;

            this.datePicker.Value = this.date = appointment.appointmentdate;
            this.timePicker.Value = DateTime.Today.Add(appointment.appointmenttime);
            this.time = appointment.appointmenttime;

            this.visitTypeComboBox.DataSource = visitService.GetAllVisitTypes();
            this.visitTypeComboBox.DisplayMember = "name";
            this.visitTypeComboBox.ValueMember = "id";
            this.visitTypeComboBox.SelectedItem = this.visit = appointment.visit;

            this.statusComboBox.DataSource = statusService.GetAllStatusTypes();
            this.statusComboBox.DisplayMember = "name";
            this.statusComboBox.ValueMember = "id";
            this.statusComboBox.SelectedItem = this.status = appointment.status;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Patient patient = (Patient)patientComboBox.SelectedItem;
            Visit visit = (Visit)visitTypeComboBox.SelectedItem;
            Status status = (Status)statusComboBox.SelectedItem;
            DateTime appointmentDate = datePicker.Value.Date;
            TimeSpan appointmentTime = timePicker.Value.TimeOfDay;

            if (!this.patient.Equals(patient) || !this.status.Equals(status) ||  !this.visit.Equals(visit) || !this.date.Equals(date) || !this.time.Equals(appointmentTime))
            {
                Appointment appointment = appointmentService.UpdateAppointment(appointmentId, patient, status, visit, appointmentDate, appointmentTime);
                string notification = (appointment == null) ? "Could not update appointment details due to database issues. Please try again later or contact the administrator!"
:                   "Appointment was successfully updated.";

                this.Close();
                MessageBox.Show(notification);
            }
            else
            {
                this.Close();
            }
        }
    }
}
