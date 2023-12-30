using MedAppointments.Data.Entities;
using MedAppointments.Services;
using MedAppointments.Util;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace MedAppointments
{
    public partial class AppointmentUserControl : UserControl
    {
        private AppointmentService appointmentService;
        private StatusService statusService;
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
        public AppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.statusService = new StatusService();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 22, 22));
            addAppointmentButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addAppointmentButton.Width, addAppointmentButton.Height, 22, 22));

            customDataGridView = new CustomDataGridView(13, 74, 1105, 621);
            panel1.Controls.Add(customDataGridView);

            customDataGridView.InitializeGridContent();
        }

        public void InitializeGridContent()
        {
            customDataGridView.Rows.Clear();

            customDataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List<Appointment> apointmentList = appointmentService.GetAllAppointments();

            int x = 0;
            foreach (Appointment a in apointmentList)
            {
                int rowIndex = customDataGridView.Rows.Add();

                DataGridViewRow gridRow = customDataGridView.Rows[rowIndex];
                gridRow.HeaderCell.Value = a.id;
                gridRow.Cells[0].Value = x++;
                gridRow.Cells[1].Value = a.patient.name + " " + a.patient.surname;
                gridRow.Cells[2].Value = a.visit.name;
                gridRow.Cells[3].Value = a.appointmentdate.ToString("dd-MM-yyyy");
                gridRow.Cells[4].Value = a.appointmenttime.ToString("hh\\:mm");
                gridRow.Cells[5].Value = a.patient.contactnumber;
            }

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
