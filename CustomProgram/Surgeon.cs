using System;

namespace HospitalManagementSystem
{
    public class Surgeon : MedicalStaff
    {

        public Surgeon(string name, string contact, DateTime dob, string workingHours, string experience):base(name, contact, dob, workingHours, experience)
        {
        }

        public override void Diagnose()
        {
            Console.WriteLine($"{Name} is diagnosing the patient.");
        }

        public override void ProvideTreatment()
        {
            Console.WriteLine($"{Name} is performing surgery.");
        }
    }
}
