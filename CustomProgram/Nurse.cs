namespace HospitalManagementSystem
{
    public abstract class Nurse : MedicalStaff
    {
        protected Nurse(string name, string contact, DateTime dob, string working_hours, string experience):base(name, contact, dob, working_hours, experience) 
        { 
        }

        public abstract void UpdatePatientRecord(Manage hospital_manager, string patientName, string newContact, string[] newSymptoms);
    }
}
