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
                appointmentdate = appointmentDate.ToUniversalTime(),
                createdat = DateTime.Now.ToUniversalTime()
            };
            databaseContext.appointments.Add(appointment);

            try
            {
                databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return null;
            }
            return appointment;
        }

        public List<Appointment> GetAllCompletedAppointments()
        {
            return databaseContext.appointments
                .Where(appointment => appointment.status.name.Equals("Completed"))
                .ToList();
        }

        public List<Appointment> GetAllPatientsTodaysAppointments()
        {
            return databaseContext.appointments
                .Where(appointment => appointment.appointmentdate.Equals(DateTime.UtcNow.Date))
                .ToList();
        }

        public List<Appointment> GetAllCanceledAppointments()
        {
            return databaseContext.appointments
                .Where(appointment => appointment.status.name.Equals("Canceled"))
                .ToList();
        }

        public List<Appointment> GetAllTodaysScheduledAppointments()
        {
            return databaseContext.appointments
                .Where(appointment => appointment.createdat.Date.Equals(DateTime.UtcNow.Date))
                 .ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            return databaseContext.appointments.Find(id);
        }


    }
}
