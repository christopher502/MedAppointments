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
    public partial class DashboardUserControl : UserControl
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
        public DashboardUserControl()
        {
            InitializeComponent();
            welcomePanelBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, welcomePanelBackground.Width, welcomePanelBackground.Height, 22, 22));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 22, 22));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 22, 22));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 22, 22));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 22, 22));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 22, 22));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 22, 22));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 22, 22));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 22, 22));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 22, 22));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, 22, 22));
            addAppointmentButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addAppointmentButton.Width, addAppointmentButton.Height, 22, 22));

        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentService appointmentService = new AppointmentService();
            appointmentService.GetAllAppointments();
        }
    }
}
