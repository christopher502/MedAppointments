namespace MedAppointments.Forms
{
    partial class LoginForm
    {

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            contactNumberTextBox = new TextBox();
            panel3 = new Panel();
            passwordTextBox = new TextBox();
            label9 = new Label();
            loginButton = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 577);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(24, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(231, 27);
            label2.TabIndex = 1;
            label2.Text = "AGENDA PLANNER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Looqie", 99.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 167);
            label1.TabIndex = 0;
            label1.Text = "ACA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(46, 48, 71);
            label3.Location = new Point(465, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 82);
            label3.TabIndex = 1;
            label3.Text = "Login";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(contactNumberTextBox);
            panel2.Location = new Point(481, 187);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 33);
            panel2.TabIndex = 6;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.BorderStyle = BorderStyle.None;
            contactNumberTextBox.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contactNumberTextBox.Location = new Point(46, 6);
            contactNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(272, 20);
            contactNumberTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(passwordTextBox);
            panel3.Location = new Point(481, 239);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 33);
            panel3.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(46, 7);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(272, 20);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.FromArgb(46, 48, 71);
            label9.Location = new Point(615, 553);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 13);
            label9.TabIndex = 10;
            label9.Text = "© 2024 All Rights Reserved";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(59, 186, 156);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(481, 291);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(134, 42);
            loginButton.TabIndex = 10;
            loginButton.Text = "LOG IN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.square_phone_hangup;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(481, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(40, 33);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources._lock;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(481, 239);
            panel5.Name = "panel5";
            panel5.Size = new Size(40, 33);
            panel5.TabIndex = 12;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(915, 576);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(loginButton);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private Button loginButton;
        private Panel panel4;
        private Panel panel5;
    }
}