namespace HospitalManagementSystem
{
    public class EmergencyNurse : Nurse
    {
        public EmergencyNurse(string name, string contact, DateTime dob, string working_hours, string experience):base(name, contact, dob, working_hours, experience) 
        { 
        }

        public override void UpdatePatientRecord(Manage hospital_manager, string patient_name, string new_contact, string[] new_symptoms)
        {
            PatientRecord record_edit = hospital_manager.FindPatientRecordByName(patient_name);

            if (record_edit != null)
            {
                record_edit.Contact = new_contact;
                record_edit.Symptoms = new_symptoms;
                Console.WriteLine($"Patient record for {patient_name} has been updated.");
                hospital_manager.SaveRecordsToFile(); 
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
