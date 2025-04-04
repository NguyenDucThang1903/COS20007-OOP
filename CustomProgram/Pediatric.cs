namespace HospitalManagementSystem
{
    public class Pediatric : Doctor
    {
        public Pediatric(string name, string contact, DateTime dob, string workingHours, string experience):base(name, contact, dob, workingHours, experience) 
        { 
        }


        public override void Diagnose()
        {
            Console.WriteLine($"{Name} (Pediatrician) is diagnosing a child patient.");
        }

        public override void ProvideTreatment()
        {
            Console.WriteLine($"{Name} (Pediatrician) is providing treatment.");
        }
    }
}
