using MedAppointments.Data.Entities;
using MedAppointments.Forms;
using MedAppointments.Services;
using MedAppointments.Util;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace MedAppointments
{
    public partial class AppointmentUserControl : UserControl
    {
        private AppointmentService appointmentService;
        private CustomDataGridView customDataGridView;
        private Doctor doctor;

        public AppointmentUserControl(Doctor doctor)
        {
            this.appointmentService = new AppointmentService();
            this.doctor = doctor;
            InitializeComponent();
            CreateDataGridView();
        }

        private void CreateDataGridView()
        {
            customDataGridView = new CustomDataGridView(13, 74, 1105, 621);
            panel1.Controls.Add(customDataGridView);
            customDataGridView.CellContentClick += EditButtonClick;
            customDataGridView.InitializeGridContent(appointmentService.GetAllAppointmentsByDoctor(doctor));
        }

        private void AddAppointmentButtonClick(object sender, EventArgs e)
        {
            using (AppointmentDetailForm appointmentDetails = new AppointmentDetailForm(customDataGridView, doctor))
            {
                appointmentDetails.StartPosition = FormStartPosition.CenterParent;
                appointmentDetails.ShowInTaskbar = false;
                appointmentDetails.ShowDialog();
            }
            customDataGridView.InitializeGridContent(appointmentService.GetAllAppointmentsByDoctor(doctor));
        }

        private void EditButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            object rowHeader = customDataGridView.Rows[e.RowIndex].HeaderCell.Value;

            using (EditAppointmentForm editAppointmentForm = new EditAppointmentForm((int)rowHeader, doctor))
            {
                editAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                editAppointmentForm.ShowInTaskbar = false;
                editAppointmentForm.ShowDialog();
            }
            customDataGridView.InitializeGridContent(appointmentService.GetAllAppointmentsByDoctor(doctor));
        }
    }
}
