using MedAppointments.Properties;

namespace MedAppointments
{
    partial class MainForm
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
            panel12 = new Panel();
            fullNameLabel = new Label();
            panel11 = new Panel();
            patientsButton = new Button();
            appointmentsButton = new Button();
            dashboardButton = new Button();
            clinicName = new Panel();
            clinicLogo = new Panel();
            headerLine = new Panel();
            panelContainer = new Panel();
            mainContainer = new Panel();
            mainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackgroundImage = Resources.down_arrow_icon;
            panel12.Location = new Point(1149, 26);
            panel12.Name = "panel12";
            panel12.Size = new Size(17, 17);
            panel12.TabIndex = 23;
            panel12.Click += MyProfileButtonClick;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Comfortaa", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(1021, 24);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(124, 20);
            fullNameLabel.TabIndex = 22;
            fullNameLabel.Text = "Name Surname";
            // 
            // panel11
            // 
            panel11.BackgroundImage = Resources.profile_icon;
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Location = new Point(980, 17);
            panel11.Name = "panel11";
            panel11.Size = new Size(35, 35);
            panel11.TabIndex = 21;
            // 
            // patientsButton
            // 
            patientsButton.FlatAppearance.BorderSize = 0;
            patientsButton.FlatStyle = FlatStyle.Flat;
            patientsButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsButton.Location = new Point(624, 19);
            patientsButton.Name = "patientsButton";
            patientsButton.RightToLeft = RightToLeft.No;
            patientsButton.Size = new Size(85, 29);
            patientsButton.TabIndex = 20;
            patientsButton.Text = "Patients";
            patientsButton.UseVisualStyleBackColor = true;
            patientsButton.Click += PatientButtonCLick;
            // 
            // appointmentsButton
            // 
            appointmentsButton.FlatAppearance.BorderSize = 0;
            appointmentsButton.FlatStyle = FlatStyle.Flat;
            appointmentsButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentsButton.Location = new Point(476, 19);
            appointmentsButton.Name = "appointmentsButton";
            appointmentsButton.Size = new Size(132, 29);
            appointmentsButton.TabIndex = 19;
            appointmentsButton.Text = "Appointments";
            appointmentsButton.UseVisualStyleBackColor = true;
            appointmentsButton.Click += AppointementsButtonClick;
            // 
            // dashboardButton
            // 
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardButton.Location = new Point(355, 19);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(105, 29);
            dashboardButton.TabIndex = 18;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += DasboardButtonClick;
            // 
            // clinicName
            // 
            clinicName.BackgroundImage = Resources.clinic_name_icon;
            clinicName.Location = new Point(103, 14);
            clinicName.Name = "clinicName";
            clinicName.Size = new Size(229, 38);
            clinicName.TabIndex = 17;
            // 
            // clinicLogo
            // 
            clinicLogo.BackgroundImage = Resources.clinic_logo_icon;
            clinicLogo.Location = new Point(36, 0);
            clinicLogo.Name = "clinicLogo";
            clinicLogo.Size = new Size(63, 66);
            clinicLogo.TabIndex = 16;
            // 
            // headerLine
            // 
            headerLine.BackColor = Color.FromArgb(248, 248, 248);
            headerLine.ForeColor = Color.FromArgb(248, 248, 248);
            headerLine.Location = new Point(36, 70);
            headerLine.Name = "headerLine";
            headerLine.Size = new Size(1130, 6);
            headerLine.TabIndex = 24;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(36, 91);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1130, 706);
            panelContainer.TabIndex = 25;
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.Transparent;
            mainContainer.Controls.Add(panelContainer);
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1206, 850);
            mainContainer.TabIndex = 26;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1202, 811);
            Controls.Add(headerLine);
            Controls.Add(panel12);
            Controls.Add(fullNameLabel);
            Controls.Add(panel11);
            Controls.Add(patientsButton);
            Controls.Add(appointmentsButton);
            Controls.Add(dashboardButton);
            Controls.Add(clinicName);
            Controls.Add(clinicLogo);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "MainForm";
            Text = "MedAppointments";
            mainContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button patientsButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel clinicName;
        private System.Windows.Forms.Panel clinicLogo;
        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Panel panelContainer;
        private Panel mainContainer;
    }
}