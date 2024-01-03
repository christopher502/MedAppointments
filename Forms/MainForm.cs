using MedAppointments.Services;
using System.Runtime.InteropServices;
using MedAppointments.Util;
using MedAppointments.Data.Entities;

namespace MedAppointments
{
    public partial class MainForm : Form
    {
        private DoctorService doctorService;
        private Doctor doctor;
        public MainForm(Doctor doctor)
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
            this.doctor = doctor;

            fullNameLabel.Text = doctor.name + " " + doctor.surname;

            addUserControl(new DashboardUserControl(doctor));

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void DasboardButtonClick(object sender, EventArgs e) => addUserControl(new DashboardUserControl(doctor));
        private void AppointementsButtonClick(object sender, EventArgs e) => addUserControl(new AppointmentUserControl(doctor));
        private void PatientButtonCLick(object sender, EventArgs e) => addUserControl(new PatientUserControl(doctor));

        private void MyProfileButtonClick(object sender, EventArgs e)
        {
            using (ProfileDetailsForm profileDetails = new ProfileDetailsForm(doctor.id))
            {
                profileDetails.StartPosition = FormStartPosition.CenterParent;
                profileDetails.ShowInTaskbar = false;
                profileDetails.ShowDialog();
            }
        }
    }
}
