namespace MedAppointments
{
    partial class AppointmentUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            appointmentsGridView = new DataGridView();
            patientId = new DataGridViewTextBoxColumn();
            patientName = new DataGridViewTextBoxColumn();
            visitType = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            contactNumber = new DataGridViewTextBoxColumn();
            label1 = new Label();
            addAppointmentButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 248, 248);
            panel1.Controls.Add(appointmentsGridView);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(addAppointmentButton);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 706);
            panel1.TabIndex = 0;
            // 
            // appointmentsGridView
            // 
            appointmentsGridView.AllowUserToAddRows = false;
            appointmentsGridView.AllowUserToDeleteRows = false;
            appointmentsGridView.AllowUserToResizeColumns = false;
            appointmentsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            appointmentsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            appointmentsGridView.BackgroundColor = Color.FromArgb(248, 248, 248);
            appointmentsGridView.BorderStyle = BorderStyle.None;
            appointmentsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            appointmentsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            appointmentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            appointmentsGridView.ColumnHeadersHeight = 55;
            appointmentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            appointmentsGridView.Columns.AddRange(new DataGridViewColumn[] { patientId, patientName, visitType, date, time, contactNumber });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            appointmentsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            appointmentsGridView.EnableHeadersVisualStyles = false;
            appointmentsGridView.GridColor = Color.FromArgb(248, 248, 248);
            appointmentsGridView.Location = new Point(13, 74);
            appointmentsGridView.MultiSelect = false;
            appointmentsGridView.Name = "appointmentsGridView";
            appointmentsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            appointmentsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            appointmentsGridView.RowHeadersVisible = false;
            appointmentsGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            appointmentsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            appointmentsGridView.Size = new Size(1107, 621);
            appointmentsGridView.TabIndex = 6;
            // 
            // patientId
            // 
            patientId.HeaderText = "#";
            patientId.Name = "patientId";
            patientId.Width = 140;
            // 
            // patientName
            // 
            patientName.HeaderText = "Patient";
            patientName.Name = "patientName";
            patientName.ReadOnly = true;
            patientName.Width = 158;
            // 
            // visitType
            // 
            visitType.HeaderText = "Visit Type";
            visitType.Name = "visitType";
            visitType.ReadOnly = true;
            visitType.Width = 158;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 158;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.Name = "time";
            time.ReadOnly = true;
            time.Width = 158;
            // 
            // contactNumber
            // 
            contactNumber.HeaderText = "Contact";
            contactNumber.Name = "contactNumber";
            contactNumber.ReadOnly = true;
            contactNumber.Width = 158;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(207, 29);
            label1.TabIndex = 2;
            label1.Text = "All appointments";
            // 
            // addAppointmentButton
            // 
            addAppointmentButton.BackColor = Color.Gainsboro;
            addAppointmentButton.FlatAppearance.BorderSize = 0;
            addAppointmentButton.FlatStyle = FlatStyle.Flat;
            addAppointmentButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addAppointmentButton.Location = new Point(957, 16);
            addAppointmentButton.Name = "addAppointmentButton";
            addAppointmentButton.Size = new Size(163, 37);
            addAppointmentButton.TabIndex = 1;
            addAppointmentButton.Text = "Add appointment   +";
            addAppointmentButton.UseVisualStyleBackColor = false;
            addAppointmentButton.Click += AddAppointmentButtonClick;
            // 
            // AppointmentUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AppointmentUserControl";
            Size = new Size(1139, 709);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAppointmentButton;
        private DataGridView appointmentsGridView;
        private DataGridViewTextBoxColumn patientId;
        private DataGridViewTextBoxColumn patientName;
        private DataGridViewTextBoxColumn visitType;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn contactNumber;
    }
}
