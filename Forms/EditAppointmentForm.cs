using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAppointments.Data.Entities;
using MedAppointments.Services;

namespace MedAppointments.Forms
{
    public partial class EditAppointmentForm : Form
    {
        private AppointmentService appointmentService;
        private PatientService patientService;
        private int appointmentId;

        private Patient patient { get; set; }
        private Visit visit { get; set; }
        private DateTime date { get; set; }
        private TimeSpan time { get; set; }
        private Status status { get; set; }

        public EditAppointmentForm(int appointmentId)
        {
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.patientService = new PatientService();
            this.appointmentId = appointmentId;

            FillAppointmentDetails();
        }

        private void FillAppointmentDetails()
        {
            Appointment appointment = appointmentService.GetAppointmentById(appointmentId);
            this.patientComboBox.DataSource = appointment.patient;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
