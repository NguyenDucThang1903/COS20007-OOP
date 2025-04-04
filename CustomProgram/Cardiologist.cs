namespace HospitalManagementSystem
{
    public class Cardiologist : Doctor
    {
        public Cardiologist(string name, string contact, DateTime dob, string workingHours, string experience):base(name, contact, dob, workingHours, experience) 
        { 
        }


        public override void Diagnose()
        {
            Console.WriteLine($"{Name} (Cardiologist) is diagnosing a heart condition.");
        }

        public override void ProvideTreatment()
        {
            Console.WriteLine($"{Name} (Cardiologist) is providing heart treatment.");
        }
    }
}
