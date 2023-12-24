using MedAppointments.Data.Entities;
using MedAppointments.Enums;
using MedAppointments.Services;
using MySqlX.XDevAPI.Relational;
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
    public partial class AppointmentUserControl : UserControl
    {
        private AppointmentService appointmentService;
        private StatusService statusService;

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

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Action";
            editButton.Width = 90;
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            appointmentsGridView.Columns.Add(editButton);
            appointmentsGridView.CellContentClick += ActionButtonsClick;

            InitializeGridContent();
        }

        private void AddAppointmentButtonClick(object sender, EventArgs e)
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
