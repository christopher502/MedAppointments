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

        public AppointmentUserControl()
        {
            this.appointmentService = new AppointmentService();
            InitializeComponent();
            CreateDataGridView();
        }

        private void CreateDataGridView()
        {
            customDataGridView = new CustomDataGridView(13, 74, 1105, 621);
            panel1.Controls.Add(customDataGridView);
            customDataGridView.CellContentClick += EditButtonClick;
            customDataGridView.InitializeGridContent(appointmentService.GetAllAppointments());
        }

        private void AddAppointmentButtonClick(object sender, EventArgs e)
        {
            using (AppointmentDetailForm appointmentDetails = new AppointmentDetailForm(customDataGridView))
            {
                appointmentDetails.StartPosition = FormStartPosition.CenterParent;
                appointmentDetails.ShowInTaskbar = false;
                appointmentDetails.ShowDialog();
            }
            customDataGridView.InitializeGridContent(appointmentService.GetAllAppointments());
        }

        private void EditButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            object rowHeader = customDataGridView.Rows[e.RowIndex].HeaderCell.Value;

            using (EditAppointmentForm editAppointmentForm = new EditAppointmentForm((int)rowHeader))
            {
                editAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                editAppointmentForm.ShowInTaskbar = false;
                editAppointmentForm.ShowDialog();
            }
            customDataGridView.InitializeGridContent(appointmentService.GetAllAppointments());
        }
    }
}
