using MedAppointments.Data.Entities;
using MedAppointments.Forms;
using MedAppointments.Properties;
using MedAppointments.Services;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MedAppointments.Util
{
    public class CustomDataGridView : DataGridView
    {
        private AppointmentService appointmentService;

        public CustomDataGridView(int locationX, int locationY, int width, int height) : base()
        {
            this.appointmentService = new AppointmentService();

            Location = new Point(locationX, locationY);
            Width = width;
            Height = height;

            CustomizeBackgroundColors();
            ConfigureColumns();
            SetColumnsAlignment();
            GeneralCustomization();
        }

        private void ConfigureColumns()
        {
            Columns.Add("numberColumn", "#");
            Columns.Add("patientColumn", "Patient");
            Columns.Add("visitColumn", "Visit Type");
            Columns.Add("dateColumn", "Date");
            Columns.Add("timeColumn", "Time");
            Columns.Add("contactColumn", "Contact");
            Columns.Add("statusColumn", "Status");

            Columns["numberColumn"].Width = 50;
            Columns["patientColumn"].Width = 200;
            Columns["visitColumn"].Width = 158;
            Columns["dateColumn"].Width = 158;
            Columns["timeColumn"].Width = 158;
            Columns["contactColumn"].Width = 158;
            Columns["statusColumn"].Width = 158;

            Columns.Add(new DataGridViewImageColumn()
            {
                Image = Resources.edit_icon,
                Width = 50
            });
        }

        private void SetColumnsAlignment()
        {
            Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
            Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter);
            Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void CustomizeBackgroundColors()
        {
            BackgroundColor = Color.FromArgb(248, 248, 248);
            GridColor = Color.FromArgb(248, 248, 248);

            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 248, 248);

            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 248, 248);

            DefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 248, 248);

            RowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 248, 248);
            RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void GeneralCustomization()
        {
            ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            ColumnHeadersHeight = 55;

            RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);


            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            RowHeadersVisible = false;
            EnableHeadersVisualStyles = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;

            Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        public void InitializeGridContent(List<Appointment> apointmentList)
        {
            Rows.Clear();

            int x = 0;
            foreach (Appointment a in apointmentList)
            {
                int rowIndex = Rows.Add();

                DataGridViewRow gridRow = Rows[rowIndex];
                gridRow.HeaderCell.Value = a.id;
                gridRow.Cells[0].Value = x++;
                gridRow.Cells[1].Value = a.patient.name + " " + a.patient.surname;
                gridRow.Cells[2].Value = a.visit.name;
                gridRow.Cells[3].Value = a.appointmentdate.ToString("dd-MM-yyyy");
                gridRow.Cells[4].Value = a.appointmenttime.ToString("hh\\:mm");
                gridRow.Cells[5].Value = a.patient.contactnumber;
                gridRow.Cells[6].Value = a.status.name;
            }
            SetRowCellHeight(40);
        }

        private void SetRowCellHeight(int cellHeight)
        {
            foreach (DataGridViewRow row in Rows)
            {
                row.Height = cellHeight;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.Padding = new Padding(0, 0, 0, 0);
                    cell.Style.Padding = new Padding(0, 0, 0, cellHeight - RowTemplate.Height);
                }
            }
        }
    }
}
