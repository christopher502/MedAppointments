using MedAppointments.Services;
using System.Runtime.InteropServices;

namespace MedAppointments
{
    public partial class MainForm : Form
    {
        private DoctorService doctorService;

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
        public MainForm()
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 25, 25));
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
