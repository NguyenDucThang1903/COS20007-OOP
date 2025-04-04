using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        private List<Patient> _patients = new List<Patient>();
        private List<MedicalStaff> _medical_staff = new List<MedicalStaff>();
        private List<Receptionist> _receptionists = new List<Receptionist>();

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
            Console.WriteLine("Patient added to the hospital.");
        }

        public void RemovePatient(Patient patient)
        {
            _patients.Remove(patient);
            Console.WriteLine("Patient removed from the hospital.");
        }

        public void AddMedicalStaff(MedicalStaff staff)
        {
            _medical_staff.Add(staff);
            Console.WriteLine("Medical staff added.");
        }

        public void AddReceptionist(Receptionist receptionist)
        {
            _receptionists.Add(receptionist);
            Console.WriteLine("Receptionist added.");
        }
    }
}
