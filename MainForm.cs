﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAppointments
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            addUserControl(new DashboardUserControl());
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void DasboardButtonClick(object sender, EventArgs e) => addUserControl(new DashboardUserControl());
    }
}
