using MedAppointments.Services;
using System.Runtime.InteropServices;
using MedAppointments.Util;

namespace MedAppointments
{
    public partial class MainForm : Form
    {
        private DoctorService doctorService;

        public MainForm()
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
            fullNameLabel.Text = doctorService.GetDoctorById(1).name +" "+ doctorService.GetDoctorById(1).surname;

            addUserControl(new DashboardUserControl());
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void DasboardButtonClick(object sender, EventArgs e) => addUserControl(new DashboardUserControl());
        private void AppointementsButtonClick(object sender, EventArgs e) => addUserControl(new AppointmentUserControl());
        private void PatientButtonCLick(object sender, EventArgs e) => addUserControl(new PatientUserControl());

        private void MyProfileButtonClick(object sender, EventArgs e)
        {
            using (ProfileDetailsForm profileDetails = new ProfileDetailsForm())
            {
                profileDetails.StartPosition = FormStartPosition.CenterParent;
                profileDetails.ShowInTaskbar = false;
                profileDetails.ShowDialog();
            }
        }
    }
}
