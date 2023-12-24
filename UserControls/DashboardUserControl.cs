using MedAppointments.Data.Entities;
using MedAppointments.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAppointments
{
    public partial class DashboardUserControl : UserControl
    {
        private AppointmentService appointmentService;
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
        public DashboardUserControl()
        {
            InitializeComponent();
            this.appointmentService = new AppointmentService();
            this.doctorService = new DoctorService();
            welcomePanelBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, welcomePanelBackground.Width, welcomePanelBackground.Height, 22, 22));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 22, 22));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 22, 22));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 22, 22));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 22, 22));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 22, 22));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 22, 22));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 22, 22));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 22, 22));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 22, 22));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, 22, 22));
            addAppointmentButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addAppointmentButton.Width, addAppointmentButton.Height, 22, 22));

            drnameLabel.Text = doctorService.GetDoctorById(1).surname;
            specialityLabel.Text = doctorService.GetDoctorById(1).speciality;

            allPatientsAppointmentsLabel.Text = appointmentService.GetAllPatientsTodaysAppointments().Count().ToString();
            todaysAppointmentsLabel.Text = appointmentService.GetAllTodaysScheduledAppointments().Count().ToString();
            completedAppointmentsLabel.Text = appointmentService.GetAllCompletedAppointments().Count.ToString();
            canceledAppointmentsLabel.Text = appointmentService.GetAllCanceledAppointments().Count.ToString();

            DateTime today = DateTime.Today;
            todaysDateLabel.Text = today.ToString("dd-MM-yyyy");

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Action";
            editButton.Width = 90;
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            appointmentsGridView.Columns.Add(editButton);
            appointmentsGridView.CellContentClick += ActionButtonsClick;

            InitializeGridContent();
        }

        private void AddApointmentButtonClick(object sender, EventArgs e)
        {
            using (AppointmentDetailForm appointmentDetails = new AppointmentDetailForm())
            {
                appointmentDetails.StartPosition = FormStartPosition.CenterParent;
                appointmentDetails.ShowInTaskbar = false;
                appointmentDetails.ShowDialog();
            }
        }

        public void InitializeGridContent()
        {
            appointmentsGridView.Rows.Clear();

            appointmentsGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List<Appointment> apointmentList = appointmentService.GetAllAppointments();

            int x = 0;
            foreach (Appointment a in apointmentList)
            {
                int rowIndex = appointmentsGridView.Rows.Add();

                DataGridViewRow gridRow = appointmentsGridView.Rows[rowIndex];
                gridRow.HeaderCell.Value = a.id;
                gridRow.Cells[0].Value = x++;
                gridRow.Cells[1].Value = a.patient.name + " " + a.patient.surname;
                gridRow.Cells[2].Value = a.visit.name;
                gridRow.Cells[3].Value = a.appointmentdate.ToString("dd-MM-yyyy");
                gridRow.Cells[4].Value = a.appointmenttime.ToString("hh\\:mm");
                gridRow.Cells[5].Value = a.patient.contactnumber;
            }

            appointmentsGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
            SetRowCellHeight(70);

            appointmentsGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void SetRowCellHeight(int cellHeight)
        {
            foreach (DataGridViewRow row in appointmentsGridView.Rows)
            {
                row.Height = cellHeight;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Padding = new Padding(0, 0, 0, 0);
                    cell.Style.Padding = new Padding(0, 0, 0, cellHeight - appointmentsGridView.RowTemplate.Height);
                }
            }
        }

        private void ActionButtonsClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
