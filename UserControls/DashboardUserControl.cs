using MedAppointments.Data.Entities;
using MedAppointments.Forms;
using MedAppointments.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAppointments.Util;

namespace MedAppointments
{
    public partial class DashboardUserControl : UserControl
    {
        private AppointmentService appointmentService;
        private DoctorService doctorService;
        private CustomDataGridView customDataGridView;
        public DashboardUserControl()
        {
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.doctorService = new DoctorService();

            ConfigureWorkspace();
            CreateDataGridView();
        }

        private void CreateDataGridView()
        {
            customDataGridView = new CustomDataGridView(13, 74, 1105, 621);
            panel10.Controls.Add(customDataGridView);
            customDataGridView.InitializeGridContent();
        }

        private void ConfigureWorkspace()
        {
            DateTime today = DateTime.Today;
            todaysDateLabel.Text = today.ToString("dd-MM-yyyy");

            drnameLabel.Text = doctorService.GetDoctorById(1).surname;
            specialityLabel.Text = doctorService.GetDoctorById(1).speciality;

            allPatientsAppointmentsLabel.Text = appointmentService.GetAllPatientsTodaysAppointments().Count().ToString();
            todaysAppointmentsLabel.Text = appointmentService.GetAllTodaysScheduledAppointments().Count().ToString();
            completedAppointmentsLabel.Text = appointmentService.GetAllCompletedAppointments().Count.ToString();
            canceledAppointmentsLabel.Text = appointmentService.GetAllCanceledAppointments().Count.ToString();
        }

        private void AddApointmentButtonClick(object sender, EventArgs e)
        {
            using (AppointmentDetailForm appointmentDetails = new AppointmentDetailForm(customDataGridView))
            {
                appointmentDetails.StartPosition = FormStartPosition.CenterParent;
                appointmentDetails.ShowInTaskbar = false;
                appointmentDetails.ShowDialog();
            }
        }
    }
}
