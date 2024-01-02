using MedAppointments.Enums;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedAppointments.Services
{
    public class PatientService
    {
        private AppointmentsContext databaseContext;
        public PatientService()
        {
            this.databaseContext = new AppointmentsContext();
        }
        
        public List<Patient> GetAllPatients()
        {
            return databaseContext.patients.AsNoTracking().Where(patient => patient.active.Equals(true)).ToList();
        }

        public Patient GetPatientById(int id)
        {
            return databaseContext.patients.Find(id);
        }


        public Patient? AddPatient(string name, string surname, string contactnumber, Gender gender, DateTime birthdate)
        {
            Patient patient = new Patient
            {
                name = name,
                surname = surname,
                contactnumber = contactnumber,
                gender = gender,
                birthdate = birthdate.ToUniversalTime(),
                active = true,
                visits = 0
            };
            databaseContext.patients.Add(patient);
            try
            {
                databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return null;
            }
            return patient;

        }

        public Patient? UpdatePatient (int id, string name, string surname, DateTime birthdate, string contactnumber, Gender gender, int visits)
        {
            Patient patient = GetPatientById(id);
            patient.name = name;
            patient.surname = surname;
            patient.birthdate = birthdate.ToUniversalTime();
            patient.contactnumber = contactnumber;
            patient.gender = gender;
            patient.visits = visits;

            try
            {
                databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return null;
            }
            return patient;

        }

        public Boolean DeletePatient(int id)
        {
            Patient patient = GetPatientById(id);
            patient.active = false;

            try
            {
                databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
