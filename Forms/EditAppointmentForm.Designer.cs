namespace MedAppointments.Forms
{
    partial class EditAppointmentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            statusComboBox = new ComboBox();
            label6 = new Label();
            datePicker = new DateTimePicker();
            visitTypeComboBox = new ComboBox();
            label7 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            label5 = new Label();
            timePicker = new DateTimePicker();
            patientComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel1.Controls.Add(statusComboBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(datePicker);
            panel1.Controls.Add(visitTypeComboBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(timePicker);
            panel1.Controls.Add(patientComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 362);
            panel1.TabIndex = 3;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.FromArgb(223, 223, 223);
            statusComboBox.FlatStyle = FlatStyle.Flat;
            statusComboBox.Font = new Font("Comfortaa", 13.15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.ItemHeight = 24;
            statusComboBox.Location = new Point(27, 231);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(226, 32);
            statusComboBox.Sorted = true;
            statusComboBox.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comfortaa", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 209);
            label6.Name = "label6";
            label6.Size = new Size(52, 19);
            label6.TabIndex = 17;
            label6.Text = "Status";
            // 
            // datePicker
            // 
            datePicker.CalendarMonthBackground = Color.FromArgb(223, 223, 223);
            datePicker.Font = new Font("Comfortaa", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.ImeMode = ImeMode.NoControl;
            datePicker.Location = new Point(27, 167);
            datePicker.Name = "datePicker";
            datePicker.RightToLeft = RightToLeft.No;
            datePicker.Size = new Size(226, 31);
            datePicker.TabIndex = 7;
            // 
            // visitTypeComboBox
            // 
            visitTypeComboBox.BackColor = Color.FromArgb(223, 223, 223);
            visitTypeComboBox.FlatStyle = FlatStyle.Flat;
            visitTypeComboBox.Font = new Font("Comfortaa", 13.15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visitTypeComboBox.FormattingEnabled = true;
            visitTypeComboBox.ItemHeight = 24;
            visitTypeComboBox.Location = new Point(273, 104);
            visitTypeComboBox.Name = "visitTypeComboBox";
            visitTypeComboBox.Size = new Size(226, 32);
            visitTypeComboBox.Sorted = true;
            visitTypeComboBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comfortaa", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(273, 82);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 14;
            label7.Text = "Visit Type";
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Comfortaa", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(125, 298);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(106, 217, 189);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(25, 287);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 41);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comfortaa", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(273, 144);
            label5.Name = "label5";
            label5.Size = new Size(43, 19);
            label5.TabIndex = 8;
            label5.Text = "Time";
            // 
            // timePicker
            // 
            timePicker.CalendarMonthBackground = Color.FromArgb(223, 223, 223);
            timePicker.Font = new Font("Comfortaa", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ImeMode = ImeMode.NoControl;
            timePicker.Location = new Point(273, 167);
            timePicker.Name = "timePicker";
            timePicker.RightToLeft = RightToLeft.No;
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(226, 31);
            timePicker.TabIndex = 7;
            // 
            // patientComboBox
            // 
            patientComboBox.BackColor = Color.FromArgb(223, 223, 223);
            patientComboBox.FlatStyle = FlatStyle.Flat;
            patientComboBox.Font = new Font("Comfortaa", 13.15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientComboBox.FormattingEnabled = true;
            patientComboBox.ItemHeight = 24;
            patientComboBox.Location = new Point(27, 104);
            patientComboBox.Name = "patientComboBox";
            patientComboBox.Size = new Size(226, 32);
            patientComboBox.Sorted = true;
            patientComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 3;
            label2.Text = "Patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 0;
            label1.Text = "Edit Appointment";
            // 
            // EditAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 362);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditAppointmentForm";
            Text = "EditAppointmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox statusComboBox;
        private Label label6;
        private DateTimePicker datePicker;
        private ComboBox visitTypeComboBox;
        private Label label7;
        private Button cancelButton;
        private Button saveButton;
        private Label label5;
        private DateTimePicker timePicker;
        private ComboBox patientComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}