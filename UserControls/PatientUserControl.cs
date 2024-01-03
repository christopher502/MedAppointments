using MedAppointments.Data.Entities;
using MedAppointments.Forms;
using MedAppointments.Properties;
using MedAppointments.Services;
using MedAppointments.Util;
using System.Data;
using System.Runtime.InteropServices;

namespace MedAppointments
{
    public partial class PatientUserControl : UserControl
    {
        private AppointmentService appointmentService;
        private PatientService patientService;

        public PatientUserControl()
        {
            InitializeComponent();
            this.patientService = new PatientService();
            this.appointmentService = new AppointmentService();

            ConfigureButtonColumns();
            InitializeGridContent();
        }

        private void AddPatientButtonClick(object sender, EventArgs e)
        {
            using (PatientDetailsForm patientDetails = new PatientDetailsForm(this))
            {
                patientDetails.StartPosition = FormStartPosition.CenterParent;
                patientDetails.ShowInTaskbar = false;
                patientDetails.ShowDialog();
            }
        }

        public void InitializeGridContent()
        {
            patientdGridView.Rows.Clear();

            patientdGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            List<Patient> patientList = patientService.GetAllPatients();

            int x = 0;
            foreach (Patient p in patientList)
            {
                int rowIndex = patientdGridView.Rows.Add();

                DataGridViewRow gridRow = patientdGridView.Rows[rowIndex];
                gridRow.HeaderCell.Value = p.id;
                gridRow.Cells[0].Value = x++;
                gridRow.Cells[1].Value = p.name + " " + p.surname;
                gridRow.Cells[2].Value = p.birthdate.ToString("dd-MM-yyyy");
                gridRow.Cells[3].Value = p.gender.ToString();
                gridRow.Cells[4].Value = p.contactnumber;
                gridRow.Cells[5].Value = appointmentService.GetCompletedAppointmentsByPatient(p).Count();
            }

            patientdGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
            patientdGridView.Columns[6].HeaderCell.Style.Padding = new Padding(38, 0, 0, 0);
            SetRowCellHeight(50);

            patientdGridView.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void SetRowCellHeight(int cellHeight)
        {
            foreach (DataGridViewRow row in patientdGridView.Rows)
            {
                row.Height = cellHeight;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Padding = new Padding(0, 0, 0, 0);
                    cell.Style.Padding = new Padding(0, 0, 0, cellHeight - patientdGridView.RowTemplate.Height);
                }
            }
        }

        private void ConfigureButtonColumns()
        {
            patientdGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Resources.delete24,
                Width = 40
            });

            patientdGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Resources.edit24_icon,
                Width = 40
            });
            patientdGridView.CellContentClick += ActionButtonsClick;
        }

        private void ActionButtonsClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                if (dataGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    object rowHeader = dataGridView.Rows[e.RowIndex].HeaderCell.Value;
                    if (e.ColumnIndex == 6)
                    {
                        DialogResult dialogResult = MessageBox.Show("Confirm removing patient ?", "Delete Patient", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            patientService.DeletePatient((int)rowHeader);
                            InitializeGridContent();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            // do nothing
                        }
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        using (EditPatientForm patientDetails = new EditPatientForm((int)rowHeader))
                        {
                            patientDetails.StartPosition = FormStartPosition.CenterParent;
                            patientDetails.ShowInTaskbar = false;
                            patientDetails.ShowDialog();
                        }
                        InitializeGridContent();
                    }
                }
            }
        }
    }
}
