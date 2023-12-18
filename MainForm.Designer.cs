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
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackgroundImage = Properties.Resources.down_arrow_icon;
            panel12.Location = new Point(1340, 30);
            panel12.Margin = new Padding(4, 3, 4, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(20, 20);
            panel12.TabIndex = 23;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Comfortaa", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(1191, 28);
            fullNameLabel.Margin = new Padding(4, 0, 4, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(124, 20);
            fullNameLabel.TabIndex = 22;
            fullNameLabel.Text = "Name Surname";
            // 
            // panel11
            // 
            panel11.BackgroundImage = Properties.Resources.profile_icon;
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Location = new Point(1143, 20);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(41, 40);
            panel11.TabIndex = 21;
            // 
            // patientsButton
            // 
            patientsButton.FlatAppearance.BorderSize = 0;
            patientsButton.FlatStyle = FlatStyle.Flat;
            patientsButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsButton.Location = new Point(728, 22);
            patientsButton.Margin = new Padding(4, 3, 4, 3);
            patientsButton.Name = "patientsButton";
            patientsButton.RightToLeft = RightToLeft.No;
            patientsButton.Size = new Size(99, 33);
            patientsButton.TabIndex = 20;
            patientsButton.Text = "Patients";
            patientsButton.UseVisualStyleBackColor = true;
            // 
            // appointmentsButton
            // 
            appointmentsButton.FlatAppearance.BorderSize = 0;
            appointmentsButton.FlatStyle = FlatStyle.Flat;
            appointmentsButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentsButton.Location = new Point(555, 22);
            appointmentsButton.Margin = new Padding(4, 3, 4, 3);
            appointmentsButton.Name = "appointmentsButton";
            appointmentsButton.Size = new Size(154, 33);
            appointmentsButton.TabIndex = 19;
            appointmentsButton.Text = "Appointments";
            appointmentsButton.UseVisualStyleBackColor = true;
            // 
            // dashboardButton
            // 
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Comfortaa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardButton.Location = new Point(414, 22);
            dashboardButton.Margin = new Padding(4, 3, 4, 3);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(122, 33);
            dashboardButton.TabIndex = 18;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            // 
            // clinicName
            // 
            clinicName.BackgroundImage = Properties.Resources.clinic_name_icon;
            clinicName.Location = new Point(120, 16);
            clinicName.Margin = new Padding(4, 3, 4, 3);
            clinicName.Name = "clinicName";
            clinicName.Size = new Size(229, 44);
            clinicName.TabIndex = 17;
            // 
            // clinicLogo
            // 
            clinicLogo.BackgroundImage = Properties.Resources.clinic_logo_icon;
            clinicLogo.Location = new Point(42, 0);
            clinicLogo.Margin = new Padding(4, 3, 4, 3);
            clinicLogo.Name = "clinicLogo";
            clinicLogo.Size = new Size(74, 76);
            clinicLogo.TabIndex = 16;
            // 
            // headerLine
            // 
            headerLine.BackColor = Color.FromArgb(248, 248, 248);
            headerLine.ForeColor = Color.FromArgb(248, 248, 248);
            headerLine.Location = new Point(42, 81);
            headerLine.Margin = new Padding(4, 3, 4, 3);
            headerLine.Name = "headerLine";
            headerLine.Size = new Size(1318, 7);
            headerLine.TabIndex = 24;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(42, 95);
            panelContainer.Margin = new Padding(4, 3, 4, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1318, 827);
            panelContainer.TabIndex = 25;
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.Transparent;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Margin = new Padding(4, 3, 4, 3);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1407, 981);
            mainContainer.TabIndex = 26;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1402, 936);
            Controls.Add(panelContainer);
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
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MedAppointments";
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