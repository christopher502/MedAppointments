using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAppointments.Configuration;

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
        private void AppointementsButtonClick(object sender, EventArgs e) => addUserControl(new AppointmentUserControl());
        private void PatientButtonCLick(object sender, EventArgs e) => addUserControl(new PatientUserControl());
    }
}
