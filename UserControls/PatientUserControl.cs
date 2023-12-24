using MedAppointments.Data.Entities;
using MedAppointments.Services;
using System.Data;
using System.Runtime.InteropServices;

namespace MedAppointments
{
    public partial class PatientUserControl : UserControl
    {
        private PatientService patientService;

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
        public PatientUserControl()
        {
            InitializeComponent();
            this.patientService = new PatientService();

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            addPatientButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addPatientButton.Width, addPatientButton.Height, 22, 22));

            AddActionButtonsColumn();
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
                gridRow.Cells[5].Value = p.visits;
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

        private void AddActionButtonsColumn()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Width = 75;
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Width = 75;
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            patientdGridView.Columns.Add(deleteButton);
            patientdGridView.Columns.Add(editButton);

            patientdGridView.CellContentClick += ActionButtonsClick;
        }

        private void ActionButtonsClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    object rowHeader = dataGridView.Rows[e.RowIndex].HeaderCell.Value;
                    if (e.ColumnIndex == 6)
                    {
                        MessageBox.Show($"Button1 clicked in row {e.RowIndex}, Row Header: {rowHeader}");
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        MessageBox.Show($"Button2 clicked in row {e.RowIndex}, Row Header: {rowHeader}");
                    }
                }
            }
        }
    }
}
