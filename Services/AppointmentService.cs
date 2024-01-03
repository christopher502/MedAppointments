using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;
using MedAppointments.Enums;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace MedAppointments.Services
{
    public class AppointmentService
    {
        private AppointmentsContext databaseContext { get; set; }

        public AppointmentService()
        {
            this.databaseContext = new AppointmentsContext();
        }

        public List<Appointment> GetAllAppointmentsByDoctor(Doctor doctor)
        {
            return databaseContext.appointments
                    .AsNoTracking()
                    .Include(p => p.patient)
                    .Include(v => v.visit)
                    .Include(s => s.status)
                    .Include(d => d.doctor)
                    .Where(a => a.doctorid == doctor.id)
                    .ToList();
        }

        public Appointment? AddAppointemnt(Patient patient, Visit visit, Status status, DateTime appointmentDate, TimeSpan appointmentTime, Doctor doctor)
        {
            Appointment appointment = new Appointment
            {
                patientid = patient.id,
                visitid = visit.id,
                statusid = status.id,
                doctorid = doctor.id,
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

        public List<Appointment> GetAllCompletedAppointmentsByDoctor(Doctor doctor)
        {
            return databaseContext.appointments
                .Where(appointment => appointment.status.name.Equals("Completed") && appointment.doctorid == doctor.id)
                .ToList();
        }

        public List<Appointment> GetAllPatientsTodaysAppointmentsByDoctor(Doctor doctor)
        {
            DateTime currentDateInUtc = DateTime.Today.ToUniversalTime();
            return databaseContext.appointments
                .Where(appointment =>  (appointment.appointmentdate.Day == currentDateInUtc.Day && appointment.appointmentdate.Month == currentDateInUtc.Month && appointment.appointmentdate.Year == currentDateInUtc.Year && !appointment.status.name.Equals("Completed") && appointment.doctorid == doctor.id))
                .AsNoTracking()
                .Include(p => p.patient)
                .Include(v => v.visit)
                .Include(s => s.status)
                .Include(d => d.doctor)
                .ToList();
        }

        public List<Appointment> GetAllCanceledAppointmentsByDoctor(Doctor doctor)
        {
            return databaseContext.appointments
                .Where(appointment => appointment.status.name.Equals("Canceled") && appointment.doctorid == doctor.id)
                .ToList();
        }

        public List<Appointment> GetAllTodaysScheduledAppointmentsByDoctor(Doctor doctor)
        {
            DateTime currentDateInUtc = DateTime.Today.ToUniversalTime();
            return databaseContext.appointments
                .Where(appointment => (appointment.createdat.Day == currentDateInUtc.Day && appointment.createdat.Month == currentDateInUtc.Month && appointment.createdat.Year == currentDateInUtc.Year && appointment.doctorid == doctor.id))
                .ToList();
        }

        public Appointment? GetAppointmentById(int id) => databaseContext.appointments
                .Include(a => a.patient)
                .Include(a => a.visit)
                .Include(a => a.status)
                .Include(a => a.doctor)
                .FirstOrDefault(a => a.id == id);

        public List<Appointment> GetCompletedAppointmentsByPatient(Patient patient)
        {
            return databaseContext.appointments
                .AsNoTracking()
                .Where(appointment => appointment.patientid == patient.id && appointment.status.name.Equals("Completed"))
                .ToList();
        }

        public Appointment UpdateAppointment(int id,Patient patient, Status status, Visit visit, DateTime date, TimeSpan time)
        {
            Appointment appointment = GetAppointmentById(id);

            appointment.patientid = patient.id;
            appointment.statusid = status.id;
            appointment.visitid = visit.id;
            appointment.appointmentdate = date.ToUniversalTime();
            appointment.appointmenttime = time;

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
