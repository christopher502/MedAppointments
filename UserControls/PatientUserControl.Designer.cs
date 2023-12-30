using System.Runtime.InteropServices;

namespace MedAppointments
{
    partial class PatientUserControl
    {
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
            patientdGridView = new DataGridView();
            patientId = new DataGridViewTextBoxColumn();
            patientName = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            contactNumber = new DataGridViewTextBoxColumn();
            visitNumber = new DataGridViewTextBoxColumn();
            addPatientButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientdGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 248, 248);
            panel1.Controls.Add(patientdGridView);
            panel1.Controls.Add(addPatientButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 700);
            panel1.TabIndex = 0;
            // 
            // patientdGridView
            // 
            patientdGridView.AllowUserToAddRows = false;
            patientdGridView.AllowUserToDeleteRows = false;
            patientdGridView.AllowUserToResizeColumns = false;
            patientdGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            patientdGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            patientdGridView.BackgroundColor = Color.FromArgb(248, 248, 248);
            patientdGridView.BorderStyle = BorderStyle.None;
            patientdGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            patientdGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Comfortaa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            patientdGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            patientdGridView.ColumnHeadersHeight = 55;
            patientdGridView.Columns.AddRange(new DataGridViewColumn[] { patientId, patientName, birthDate, gender, contactNumber, visitNumber });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            patientdGridView.DefaultCellStyle = dataGridViewCellStyle3;
            patientdGridView.EnableHeadersVisualStyles = false;
            patientdGridView.GridColor = Color.FromArgb(248, 248, 248);
            patientdGridView.Location = new Point(13, 74);
            patientdGridView.MultiSelect = false;
            patientdGridView.Name = "patientdGridView";
            patientdGridView.ReadOnly = true;
            patientdGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle4.Font = new Font("Comfortaa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            patientdGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            patientdGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            patientdGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            patientdGridView.Size = new Size(1107, 621);
            patientdGridView.TabIndex = 5;
            // 
            // patientId
            // 
            patientId.HeaderText = "#";
            patientId.Name = "patientId";
            patientId.ReadOnly = true;
            patientId.Width = 158;
            // 
            // patientName
            // 
            patientName.HeaderText = "Patient Name";
            patientName.Name = "patientName";
            patientName.ReadOnly = true;
            patientName.Width = 158;
            // 
            // birthDate
            // 
            birthDate.HeaderText = "Date of Birth";
            birthDate.Name = "birthDate";
            birthDate.ReadOnly = true;
            birthDate.Width = 158;
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 158;
            // 
            // contactNumber
            // 
            contactNumber.HeaderText = "Contact ";
            contactNumber.Name = "contactNumber";
            contactNumber.ReadOnly = true;
            contactNumber.Width = 158;
            // 
            // visitNumber
            // 
            visitNumber.HeaderText = "Visits";
            visitNumber.Name = "visitNumber";
            visitNumber.ReadOnly = true;
            visitNumber.Width = 158;
            // 
            // addPatientButton
            // 
            addPatientButton.BackColor = Color.Gainsboro;
            addPatientButton.BackgroundImageLayout = ImageLayout.None;
            addPatientButton.FlatAppearance.BorderSize = 0;
            addPatientButton.FlatStyle = FlatStyle.Flat;
            addPatientButton.Font = new Font("Comfortaa", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPatientButton.Location = new Point(957, 16);
            addPatientButton.Name = "addPatientButton";
            addPatientButton.Size = new Size(163, 37);
            addPatientButton.TabIndex = 4;
            addPatientButton.Text = "Add patient   +";
            addPatientButton.UseVisualStyleBackColor = false;
            addPatientButton.Click += AddPatientButtonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 3;
            label1.Text = "All patients";
            // 
            // PatientUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PatientUserControl";
            Size = new Size(1133, 700);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientdGridView).EndInit();
            ResumeLayout(false);


            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            addPatientButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addPatientButton.Width, addPatientButton.Height, 22, 22));
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPatientButton;
        private DataGridView patientdGridView;
        private DataGridViewTextBoxColumn patientId;
        private DataGridViewTextBoxColumn patientName;
        private DataGridViewTextBoxColumn birthDate;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn contactNumber;
        private DataGridViewTextBoxColumn visitNumber;
    }
}
