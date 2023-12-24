using MedAppointments.Enums;
using MedAppointments.Services;
using MedAppointments.Util;
using MedAppointments.Data.Entities;

namespace MedAppointments
{
    public partial class PatientDetailsForm : Form
    {
        private PatientService patientService;
        private UserControl userControl;

        public PatientDetailsForm(UserControl userControl)
        {
            InitializeComponent();
            this.patientService = new PatientService();
            this.userControl = userControl;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string surname = surnameInput.Text;
            string contactnumber = numberInput.Text;
            DateTime birthdate = birthDatePicker.Value;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), genderComboBox.SelectedItem.ToString());

            if (Utils.ValidatePatientInputs(name,surname,contactnumber,birthdate))
            {
                Patient? patient = patientService.AddPatient(name, surname, contactnumber, gender, birthdate);
                
                string notification = (patient == null) ? "Could not add new patient due to database issues. Please try again later or contact the administrator!" 
                    : "Patinet '" + patient.name + " " + patient.surname + "' was successfully added.";

                this.Close();
                MessageBox.Show(notification);
            }

            ((PatientUserControl)userControl).InitializeGridContent();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
