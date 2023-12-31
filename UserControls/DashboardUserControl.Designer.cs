﻿using System.Runtime.InteropServices;

namespace MedAppointments
{
    partial class DashboardUserControl
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
            welcomePanelBackground = new Panel();
            drnameLabel = new Label();
            label12 = new Label();
            specialityLabel = new Label();
            panel1 = new Panel();
            todaysDateLabel = new Label();
            label10 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            allPatientsAppointmentsLabel = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            todaysAppointmentsLabel = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel8 = new Panel();
            completedAppointmentsLabel = new Label();
            label5 = new Label();
            panel5 = new Panel();
            panel9 = new Panel();
            canceledAppointmentsLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            panel10 = new Panel();
            label9 = new Label();
            addAppointmentButton = new Button();
            welcomePanelBackground.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // welcomePanelBackground
            // 
            welcomePanelBackground.BackgroundImage = Properties.Resources.welcome_panel_background;
            welcomePanelBackground.Controls.Add(drnameLabel);
            welcomePanelBackground.Controls.Add(label12);
            welcomePanelBackground.Controls.Add(specialityLabel);
            welcomePanelBackground.Location = new Point(3, 3);
            welcomePanelBackground.Name = "welcomePanelBackground";
            welcomePanelBackground.Size = new Size(704, 130);
            welcomePanelBackground.TabIndex = 6;
            // 
            // drnameLabel
            // 
            drnameLabel.AutoSize = true;
            drnameLabel.BackColor = Color.FromArgb(243, 247, 255);
            drnameLabel.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drnameLabel.Location = new Point(369, 13);
            drnameLabel.Name = "drnameLabel";
            drnameLabel.Size = new Size(140, 33);
            drnameLabel.TabIndex = 2;
            drnameLabel.Text = "Dr. Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(243, 247, 255);
            label12.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(142, 13);
            label12.Name = "label12";
            label12.Size = new Size(228, 33);
            label12.TabIndex = 1;
            label12.Text = "Welcome back,";
            // 
            // specialityLabel
            // 
            specialityLabel.AutoSize = true;
            specialityLabel.BackColor = Color.FromArgb(243, 247, 255);
            specialityLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialityLabel.Location = new Point(144, 54);
            specialityLabel.Name = "specialityLabel";
            specialityLabel.Size = new Size(76, 20);
            specialityLabel.TabIndex = 0;
            specialityLabel.Text = "Speciality";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 247, 255);
            panel1.Controls.Add(todaysDateLabel);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(728, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 129);
            panel1.TabIndex = 7;
            // 
            // todaysDateLabel
            // 
            todaysDateLabel.AutoSize = true;
            todaysDateLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todaysDateLabel.Location = new Point(117, 52);
            todaysDateLabel.Name = "todaysDateLabel";
            todaysDateLabel.Size = new Size(160, 31);
            todaysDateLabel.TabIndex = 1;
            todaysDateLabel.Text = "09/06/2023";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(157, 29);
            label10.Name = "label10";
            label10.Size = new Size(81, 24);
            label10.TabIndex = 0;
            label10.Text = "Today is";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 248, 248);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 80);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(248, 248, 248);
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 39);
            label2.Name = "label2";
            label2.Size = new Size(141, 16);
            label2.TabIndex = 17;
            label2.Text = "Today's appointments";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(231, 249, 244);
            panel6.Controls.Add(allPatientsAppointmentsLabel);
            panel6.Location = new Point(7, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(65, 65);
            panel6.TabIndex = 12;
            // 
            // allPatientsAppointmentsLabel
            // 
            allPatientsAppointmentsLabel.AutoSize = true;
            allPatientsAppointmentsLabel.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allPatientsAppointmentsLabel.ForeColor = Color.FromArgb(47, 208, 205);
            allPatientsAppointmentsLabel.Location = new Point(18, 15);
            allPatientsAppointmentsLabel.Name = "allPatientsAppointmentsLabel";
            allPatientsAppointmentsLabel.Size = new Size(32, 33);
            allPatientsAppointmentsLabel.TabIndex = 2;
            allPatientsAppointmentsLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(248, 248, 248);
            label1.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(47, 208, 205);
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 16;
            label1.Text = "All patients";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(248, 248, 248);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(291, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 80);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(248, 248, 248);
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 39);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 18;
            label4.Text = "Appointments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(248, 248, 248);
            label3.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(122, 50, 255);
            label3.Location = new Point(84, 16);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 18;
            label3.Text = "Todays";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(241, 232, 255);
            panel7.Controls.Add(todaysAppointmentsLabel);
            panel7.Location = new Point(7, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(65, 65);
            panel7.TabIndex = 13;
            // 
            // todaysAppointmentsLabel
            // 
            todaysAppointmentsLabel.AutoSize = true;
            todaysAppointmentsLabel.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todaysAppointmentsLabel.ForeColor = Color.FromArgb(122, 50, 255);
            todaysAppointmentsLabel.Location = new Point(18, 15);
            todaysAppointmentsLabel.Name = "todaysAppointmentsLabel";
            todaysAppointmentsLabel.Size = new Size(32, 33);
            todaysAppointmentsLabel.TabIndex = 3;
            todaysAppointmentsLabel.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(248, 248, 248);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(579, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 80);
            panel4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(248, 248, 248);
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 39);
            label6.Name = "label6";
            label6.Size = new Size(121, 16);
            label6.TabIndex = 19;
            label6.Text = "Of all appointments";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(231, 249, 244);
            panel8.Controls.Add(completedAppointmentsLabel);
            panel8.Location = new Point(7, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(65, 65);
            panel8.TabIndex = 14;
            // 
            // completedAppointmentsLabel
            // 
            completedAppointmentsLabel.AutoSize = true;
            completedAppointmentsLabel.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedAppointmentsLabel.ForeColor = Color.FromArgb(3, 191, 102);
            completedAppointmentsLabel.Location = new Point(18, 15);
            completedAppointmentsLabel.Name = "completedAppointmentsLabel";
            completedAppointmentsLabel.Size = new Size(32, 33);
            completedAppointmentsLabel.TabIndex = 4;
            completedAppointmentsLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(248, 248, 248);
            label5.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(3, 191, 102);
            label5.Location = new Point(84, 16);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 19;
            label5.Text = "Completed";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(248, 248, 248);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(867, 139);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 80);
            panel5.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(250, 230, 230);
            panel9.Controls.Add(canceledAppointmentsLabel);
            panel9.Location = new Point(7, 8);
            panel9.Name = "panel9";
            panel9.Size = new Size(65, 65);
            panel9.TabIndex = 15;
            // 
            // canceledAppointmentsLabel
            // 
            canceledAppointmentsLabel.AutoSize = true;
            canceledAppointmentsLabel.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            canceledAppointmentsLabel.ForeColor = Color.FromArgb(221, 24, 24);
            canceledAppointmentsLabel.Location = new Point(18, 15);
            canceledAppointmentsLabel.Name = "canceledAppointmentsLabel";
            canceledAppointmentsLabel.Size = new Size(32, 33);
            canceledAppointmentsLabel.TabIndex = 5;
            canceledAppointmentsLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(248, 248, 248);
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 39);
            label8.Name = "label8";
            label8.Size = new Size(121, 16);
            label8.TabIndex = 20;
            label8.Text = "Of all appointments";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(248, 248, 248);
            label7.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(221, 24, 24);
            label7.Location = new Point(84, 16);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 20;
            label7.Text = "Canceled";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(248, 248, 248);
            panel10.Controls.Add(label9);
            panel10.Controls.Add(addAppointmentButton);
            panel10.Location = new Point(3, 237);
            panel10.Name = "panel10";
            panel10.Size = new Size(1130, 470);
            panel10.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 23);
            label9.Name = "label9";
            label9.Size = new Size(184, 20);
            label9.TabIndex = 1;
            label9.Text = "Today's appointments";
            // 
            // addAppointmentButton
            // 
            addAppointmentButton.BackColor = Color.Gainsboro;
            addAppointmentButton.FlatAppearance.BorderSize = 0;
            addAppointmentButton.FlatStyle = FlatStyle.Flat;
            addAppointmentButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addAppointmentButton.Location = new Point(952, 17);
            addAppointmentButton.Name = "addAppointmentButton";
            addAppointmentButton.Size = new Size(163, 37);
            addAppointmentButton.TabIndex = 0;
            addAppointmentButton.Text = "Add appointment   +";
            addAppointmentButton.UseVisualStyleBackColor = false;
            addAppointmentButton.Click += AddApointmentButtonClick;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel10);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(welcomePanelBackground);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardUserControl";
            Size = new Size(1137, 709);
            welcomePanelBackground.ResumeLayout(false);
            welcomePanelBackground.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel welcomePanelBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label drnameLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label specialityLabel;
        private System.Windows.Forms.Label todaysDateLabel;
        private System.Windows.Forms.Label allPatientsAppointmentsLabel;
        private System.Windows.Forms.Label todaysAppointmentsLabel;
        private System.Windows.Forms.Label completedAppointmentsLabel;
        private System.Windows.Forms.Label canceledAppointmentsLabel;
    }
}
