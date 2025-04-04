namespace HospitalManagementSystem
{
    public class Doctor : MedicalStaff, IObserver
    {
        public Doctor(string name, string contact, DateTime dob, string workingHours, string experience):base(name, contact, dob, workingHours, experience) 
        { 
        }

        public void Update(Patient patient)
        {
            Console.WriteLine($"Doctor {Name} has been notified of the patient's update: {patient.Name}");

            Console.WriteLine($"Updated Symptoms: {string.Join(", ", patient.Symptoms)}");
        }

        public override void Diagnose()
        {
            Console.WriteLine($"Doctor {Name} is diagnosing the patient.");
        }

        public override void ProvideTreatment()
        {
            Console.WriteLine($"Doctor {Name} is providing treatment.");
        }
    }

}
