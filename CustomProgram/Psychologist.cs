namespace HospitalManagementSystem
{
    public class Psychologist : Doctor
    {
        public Psychologist(string name, string contact, DateTime dob, string working_hours, string experience):base(name, contact, dob, working_hours, experience) 
        { 
        }


        public override void Diagnose()
        {
            Console.WriteLine($"{Name} (Psychologist) is diagnosing a mental health condition.");
        }

        public override void ProvideTreatment()
        {
            Console.WriteLine($"{Name} (Psychologist) is providing mental health treatment.");
        }
    }
}
