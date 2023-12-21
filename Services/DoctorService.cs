using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using MedAppointments.Data.DatabaseContext;
using MedAppointments.Data.Entities;
using MedAppointments.Enums;
using Microsoft.EntityFrameworkCore;

namespace MedAppointments.Services
{
    internal class DoctorService
    {
        private AppointmentsContext databaseContext;
        public DoctorService()
        {
            this.databaseContext = new AppointmentsContext();
        }

        public List<Doctor> GetAllDoctors()
        {
            return databaseContext.doctors.ToList();

        }

        public Doctor GetDoctorById(int id)
        {
            return databaseContext.doctors.Find(id);
        } 

        public Doctor UpdateDoctorProfile(int id, string name, string surname, DateTime birthdate, string contactnumber, Gender gender, string speciality)
        {
            Doctor doctor = GetDoctorById(id);
            doctor.name = name;
            doctor.surname = surname;
            doctor.speciality = speciality;
            doctor.birthdate = birthdate.ToUniversalTime();
            doctor.gender = gender;

            try
            {
                databaseContext.SaveChanges();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return null;
            }
            return doctor;


        }
    }
}
