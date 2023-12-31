﻿using System.Runtime.InteropServices;

namespace MedAppointments
{
    partial class AppointmentUserControl
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
            panel1 = new Panel();
            label1 = new Label();
            addAppointmentButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 248, 248);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(addAppointmentButton);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 706);
            panel1.TabIndex = 0;
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
            ResumeLayout(false);

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 22, 22));
            addAppointmentButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addAppointmentButton.Width, addAppointmentButton.Height, 22, 22));
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAppointmentButton;
    }
}
