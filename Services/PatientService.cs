using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedAppointments.Enums;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;

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
            return databaseContext.patients.ToList();
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
    }
}
