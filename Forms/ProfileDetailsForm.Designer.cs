namespace MedAppointments
{
    partial class ProfileDetailsForm
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
            label7 = new Label();
            surnameInput = new TextBox();
            cancelButton = new Button();
            saveButton = new Button();
            label6 = new Label();
            specialityInput = new TextBox();
            label5 = new Label();
            birthDatePicker = new DateTimePicker();
            label4 = new Label();
            genderComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            numberInput = new TextBox();
            nameInput = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(surnameInput);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(specialityInput);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(birthDatePicker);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(genderComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numberInput);
            panel1.Controls.Add(nameInput);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 362);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(273, 82);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 14;
            label7.Text = "Surname";
            // 
            // surnameInput
            // 
            surnameInput.BackColor = Color.FromArgb(223, 223, 223);
            surnameInput.BorderStyle = BorderStyle.None;
            surnameInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            surnameInput.Location = new Point(273, 104);
            surnameInput.Multiline = true;
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(226, 32);
            surnameInput.TabIndex = 13;
            // 
            // cancelButton
            // 
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(125, 298);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButtonClick;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(106, 217, 189);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(25, 287);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 41);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButtonClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(273, 208);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 10;
            label6.Text = "Speciality";
            // 
            // specialityInput
            // 
            specialityInput.BackColor = Color.FromArgb(223, 223, 223);
            specialityInput.BorderStyle = BorderStyle.None;
            specialityInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialityInput.Location = new Point(273, 231);
            specialityInput.Multiline = true;
            specialityInput.Name = "specialityInput";
            specialityInput.Size = new Size(226, 32);
            specialityInput.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(273, 144);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth";
            // 
            // birthDatePicker
            // 
            birthDatePicker.CalendarMonthBackground = Color.FromArgb(223, 223, 223);
            birthDatePicker.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthDatePicker.Format = DateTimePickerFormat.Short;
            birthDatePicker.ImeMode = ImeMode.NoControl;
            birthDatePicker.Location = new Point(273, 167);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.RightToLeft = RightToLeft.No;
            birthDatePicker.Size = new Size(226, 29);
            birthDatePicker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 208);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = Color.FromArgb(223, 223, 223);
            genderComboBox.FlatStyle = FlatStyle.Flat;
            genderComboBox.Font = new Font("Microsoft Sans Serif", 13.15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 22;
            genderComboBox.Location = new Point(27, 231);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(226, 30);
            genderComboBox.Sorted = true;
            genderComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 4;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // numberInput
            // 
            numberInput.BackColor = Color.FromArgb(223, 223, 223);
            numberInput.BorderStyle = BorderStyle.None;
            numberInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberInput.Location = new Point(27, 167);
            numberInput.Multiline = true;
            numberInput.Name = "numberInput";
            numberInput.Size = new Size(226, 32);
            numberInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.BackColor = Color.FromArgb(223, 223, 223);
            nameInput.BorderStyle = BorderStyle.None;
            nameInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameInput.Location = new Point(27, 104);
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(226, 32);
            nameInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 0;
            label1.Text = "My Profile";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(424, 298);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += LogOutButonClick;
            // 
            // ProfileDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(529, 361);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProfileDetailsForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox specialityInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox surnameInput;
        private Button button1;
    }
}