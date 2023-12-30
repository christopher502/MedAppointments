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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public DashboardUserControl()
        {
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.doctorService = new DoctorService();
            welcomePanelBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, welcomePanelBackground.Width, welcomePanelBackground.Height, 22, 22));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 22, 22));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 22, 22));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 22, 22));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 22, 22));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 22, 22));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 22, 22));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 22, 22));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 22, 22));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 22, 22));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, 22, 22));
            addAppointmentButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addAppointmentButton.Width, addAppointmentButton.Height, 22, 22));

            drnameLabel.Text = doctorService.GetDoctorById(1).surname;
            specialityLabel.Text = doctorService.GetDoctorById(1).speciality;

            allPatientsAppointmentsLabel.Text = appointmentService.GetAllPatientsTodaysAppointments().Count().ToString();
            todaysAppointmentsLabel.Text = appointmentService.GetAllTodaysScheduledAppointments().Count().ToString();
            completedAppointmentsLabel.Text = appointmentService.GetAllCompletedAppointments().Count.ToString();
            canceledAppointmentsLabel.Text = appointmentService.GetAllCanceledAppointments().Count.ToString();

            DateTime today = DateTime.Today;
            todaysDateLabel.Text = today.ToString("dd-MM-yyyy");

            customDataGridView = new CustomDataGridView(12,73,1100,390);
            panel10.Controls.Add(customDataGridView);

            customDataGridView.InitializeGridContent();
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
