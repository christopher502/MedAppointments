using MedAppointments.Data.Entities;
using MedAppointments.Services;
using MedAppointments.Util;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace MedAppointments
{
    public partial class AppointmentUserControl : UserControl
    {
        private CustomDataGridView customDataGridView;

        public AppointmentUserControl()
        {
            InitializeComponent();
            CreateDataGridView();
        }

        private void CreateDataGridView()
        {
            customDataGridView = new CustomDataGridView(13, 74, 1105, 621);
            panel1.Controls.Add(customDataGridView);
            customDataGridView.InitializeGridContent();
        }

        private void AddAppointmentButtonClick(object sender, EventArgs e)
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
