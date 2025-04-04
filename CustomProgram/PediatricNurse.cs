namespace HospitalManagementSystem
{
    public class PediatricNurse : Nurse
    {
        public PediatricNurse(string name, string contact, DateTime dob, string working_hours, string experience):base(name, contact, dob, working_hours, experience) 
        { 
        }

        public override void UpdatePatientRecord(Manage hospital_manager, string patient_name, string new_contact, string[] new_symptoms)
        {
            PatientRecord recordToEdit = hospital_manager.FindPatientRecordByName(patient_name);

            if (recordToEdit != null)
            {
                recordToEdit.Contact = new_contact;
                recordToEdit.Symptoms = new_symptoms;
                Console.WriteLine($"Patient record for {patient_name} has been updated.");
                hospital_manager.SaveRecordsToFile();  // Save updated records to file
            }
            else
            {
                Console.WriteLine($"No patient record found for {patient_name}.");
            }
        }

        public override void Diagnose() { }

        public override void ProvideTreatment() { }
    }
}
