using MedAppointments.Data.Entities;
using MedAppointments.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAppointments
{
    public partial class PatientUserControl : UserControl
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
        public PatientUserControl()
        {
            InitializeComponent();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 22, 22));
            addPatientButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addPatientButton.Width, addPatientButton.Height, 22, 22));
        }

        private void AddPatientButtonClick(object sender, EventArgs e)
        {
            using (PatientDetailsForm patientDetails = new PatientDetailsForm())
            {
                patientDetails.StartPosition = FormStartPosition.CenterParent;
                patientDetails.ShowInTaskbar = false;
                patientDetails.ShowDialog();
            }
        }
    }
}
