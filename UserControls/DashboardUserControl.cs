﻿using MedAppointments.Data.Entities;
using MedAppointments.Forms;
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
using MedAppointments.Util;
using System.Xml.Linq;

namespace MedAppointments
{
    public partial class DashboardUserControl : UserControl
    {
        private AppointmentService appointmentService;
        private DoctorService doctorService;
        private CustomDataGridView customDataGridView;
        private Doctor doctor;
        public DashboardUserControl(Doctor doctor)
        {
            InitializeComponent();
            CreateRoundedCorners();

            this.doctorService = new DoctorService();
            this.appointmentService = new AppointmentService();
            customDataGridView = new CustomDataGridView(13, 74, 1105, 621);

            this.doctor = doctorService.GetDoctorById(doctor.id);


            customDataGridView.CellContentClick += EditButtonClick;
            panel10.Controls.Add(customDataGridView);

            ConfigureWorkspace();
            ConfigureStatistics();
            customDataGridView.InitializeGridContent(appointmentService.GetAllPatientsTodaysAppointmentsByDoctor(doctor));
        }
        private void ConfigureWorkspace()
        {
            DateTime today = DateTime.Today;
            todaysDateLabel.Text = today.ToString("dd-MM-yyyy");

            drnameLabel.Text = doctor.name;
            specialityLabel.Text = doctor.speciality;
        }

        private void ConfigureStatistics()
        {
            allPatientsAppointmentsLabel.Text = appointmentService.GetAllPatientsTodaysAppointmentsByDoctor(doctor).Count().ToString();
            todaysAppointmentsLabel.Text = appointmentService.GetAllTodaysScheduledAppointmentsByDoctor(doctor).Count().ToString();
            completedAppointmentsLabel.Text = appointmentService.GetAllCompletedAppointmentsByDoctor(doctor).Count.ToString();
            canceledAppointmentsLabel.Text = appointmentService.GetAllCanceledAppointmentsByDoctor(doctor).Count.ToString();
        }

        private void AddApointmentButtonClick(object sender, EventArgs e)
        {
            using (AppointmentDetailForm appointmentDetails = new AppointmentDetailForm(customDataGridView, doctor))
            {
                appointmentDetails.StartPosition = FormStartPosition.CenterParent;
                appointmentDetails.ShowInTaskbar = false;
                appointmentDetails.ShowDialog();
            }
            ConfigureStatistics();
            customDataGridView.InitializeGridContent(appointmentService.GetAllPatientsTodaysAppointmentsByDoctor(doctor));
        }


        private void EditButtonClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

                if (dataGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    object rowHeader = dataGridView.Rows[e.RowIndex].HeaderCell.Value;

                    using (EditAppointmentForm editAppointmentForm = new EditAppointmentForm((int)rowHeader, doctor))
                    {
                        editAppointmentForm.StartPosition = FormStartPosition.CenterParent;
                        editAppointmentForm.ShowInTaskbar = false;
                        editAppointmentForm.ShowDialog();
                    }
                    ConfigureStatistics();
                    customDataGridView.InitializeGridContent(appointmentService.GetAllPatientsTodaysAppointmentsByDoctor(doctor));
                }
            }
        }

        private void CreateRoundedCorners()
        {
            welcomePanelBackground.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, welcomePanelBackground.Width, welcomePanelBackground.Height, 25, 25));
            addAppointmentButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addAppointmentButton.Width, addAppointmentButton.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 25, 25));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 25, 25));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 25, 25));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 25, 25));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 25, 25));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 25, 25));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 25, 25));
            panel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel9.Width, panel9.Height, 25, 25));
            panel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel10.Width, panel10.Height, 25, 25));
        }
    }
}
