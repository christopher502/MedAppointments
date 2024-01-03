using MedAppointments.Data.Entities;
using MedAppointments.Services;
using MedAppointments.Util;
using Microsoft.IdentityModel.Tokens;

namespace MedAppointments.Forms
{
    public partial class LoginForm : Form
    {
        private DoctorService doctorService;
        public LoginForm()
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string contactnumber = contactNumberTextBox.Text;
            string password = passwordTextBox.Text;

            if (!contactnumber.IsNullOrEmpty() || !password.IsNullOrEmpty())
            {
                Doctor? doctor = doctorService.GetDoctorByContactNumber(contactnumber);
                if (doctor != null && PasswordHasher.VerifyPassword(password,doctor.password))
                {
                    MainForm main = new MainForm(doctor);
                    this.Hide();
                    main.Show();
                } else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            else
            {
                MessageBox.Show("Username and password cannot be empty. Please fill in the inputs!");
            }
        }
    }
}
