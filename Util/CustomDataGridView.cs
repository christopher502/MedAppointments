using MedAppointments.Forms;
using System.Security.Cryptography;

namespace MedAppointments.Util
{
    internal class CustomDataGridView : DataGridView
    {
        private int locationX;
        private int locationY;
        private int width;
        private int height;

        public CustomDataGridView(int locationX, int locationY, int width, int height) : base()
        {
            this.locationX = locationX;
            this.locationY = locationY;
            this.width = width;
            this.height = height;

            Location = new Point(locationX, locationY);
            Width = width;
            Height = height;

            CustomizeBackgroundColors();
            ConfigureColumns();
            SetColumnsAlignment();
            GeneralCustomization();

            CellContentClick += ActionButtonsClick;
        }

        private void ConfigureColumns()
        {
            Columns.Add("numberColumn", "#");
            Columns.Add("patientColumn", "Patient");
            Columns.Add("visitColumn", "Visit Type");
            Columns.Add("dateColumn", "Date");
            Columns.Add("timeColumn", "Time");
            Columns.Add("contactColumn", "Contact");

            Columns["numberColumn"].Width = 50;
            Columns["patientColumn"].Width = 250;
            Columns["visitColumn"].Width = 158;
            Columns["dateColumn"].Width = 158;
            Columns["timeColumn"].Width = 158;
            Columns["contactColumn"].Width = 158;

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Width = 150;
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            Columns.Add(editColumn);
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

        private void ActionButtonsClick(object sender, DataGridViewCellEventArgs e)
        {
            object rowHeader = Rows[e.RowIndex].HeaderCell.Value;

            using (EditAppointmentForm editAppointmentForm = new EditAppointmentForm((int)rowHeader))
            {
                editAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                editAppointmentForm.ShowInTaskbar = false;
                editAppointmentForm.ShowDialog();
            }
        }

    }
}
