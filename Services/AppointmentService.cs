using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace MedAppointments.Services
{
    public class AppointmentService
    {
        private AppointmentsContext databaseContext { get; set; }

        public AppointmentService()
        {
            this.databaseContext = new AppointmentsContext();
        }

        public List<Appointment> GetAllAppointments()
        {
            return databaseContext.appointments
                    .Include(p => p.patient)
                    .Include(v => v.visit)
                    .Include(s => s.status)
                    .ToList();
        }

        public Appointment? AddAppointemnt(Patient patient, Visit visit, Status status, DateTime appointmentDate, TimeSpan appointmentTime)
        {
            Appointment appointment = new Appointment
            {
                patientid = patient.id,
                visitid = visit.id,
                statusid = status.id,
                appointmenttime = appointmentTime,
                appointmentdate = appointmentDate.ToUniversalTime()
            };
            databaseContext.appointments.Add(appointment);

            try
            {
                databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return null;
            }
            return appointment;
        }
    }
}
