using MedAppointments.Services;
using MedAppointments.Data.Entities;
using MedAppointments.Util;

namespace MedAppointments
{
    public partial class AppointmentDetailForm : Form
    {
        private AppointmentService appointmentService;
        private PatientService patientService;
        private VisitService visitService;
        private StatusService statusService;
        private CustomDataGridView customDataGridView;

        public AppointmentDetailForm(CustomDataGridView customDataGridView)
        {
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.patientService = new PatientService();
            this.visitService = new VisitService();
            this.statusService = new StatusService();
            this.customDataGridView = customDataGridView;

            this.patientComboBox.DataSource = patientService.GetAllPatients();
            this.patientComboBox.SelectedIndex = -1;

            this.visitTypeComboBox.DataSource = visitService.GetAllVisitTypes();
            this.visitTypeComboBox.SelectedIndex = -1;

            this.statusComboBox.DataSource = statusService.GetAllStatusTypes();
            this.statusComboBox.SelectedIndex = -1;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (patientComboBox.SelectedIndex == -1 || visitTypeComboBox.SelectedIndex == -1 || statusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required. Please make sure you filled them all ");
            } else
            {
                Patient patient = (Patient)patientComboBox.SelectedItem;
                Visit visit = (Visit)visitTypeComboBox.SelectedItem;
                Status status = (Status)statusComboBox.SelectedItem;
                DateTime appointmentDate = datePicker.Value.Date;
                TimeSpan appointmentTime = timePicker.Value.TimeOfDay;


                Appointment? appointment = appointmentService.AddAppointemnt(patient, visit, status, appointmentDate, appointmentTime);
                string notification = (appointment == null) ? "Could not add new appointment due to database issues. Please try again later or contact the administrator!"
                                            : "Appointment for patient: '" + patient.name + " " + patient.surname + "' was successfully added.";

                this.Close();
                MessageBox.Show(notification);
            }
            customDataGridView.InitializeGridContent();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
