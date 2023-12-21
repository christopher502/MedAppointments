namespace MedAppointments
{
    partial class PatientUserControl
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
            panel1 = new Panel();
            addPatientButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 248, 248);
            panel1.Controls.Add(addPatientButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 703);
            panel1.TabIndex = 0;
            // 
            // addPatientButton
            // 
            addPatientButton.BackColor = Color.White;
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
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PatientUserControl";
            Size = new Size(1139, 706);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPatientButton;
    }
}
