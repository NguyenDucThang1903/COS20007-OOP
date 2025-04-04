namespace HospitalManagementSystem
{
    public class PatientRecord
    {
        public PatientRecord(string name, DateTime dob, string contact, string[] symptoms, string treatment_plan, string assigned_staff)
        {
            Name = name;
            DateOfBirth = dob;
            Contact = contact;
            Symptoms = symptoms;
            TreatmentPlan = treatment_plan;
            AssignedStaff = assigned_staff;
        }

        public void DisplayRecord()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Date of Birth: {DateOfBirth:yyyy-MM-dd}");
            Console.WriteLine($"Contact: {Contact}");
            Console.WriteLine($"Symptoms: {string.Join(", ", Symptoms)}");
            Console.WriteLine($"Treatment Plan: {TreatmentPlan}");
            Console.WriteLine($"Assigned Medical Staff: {AssignedStaff}");
        }

        public string Name
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string Contact
        {
            get;
            set;
        }
        public string[] Symptoms
        {
            get;
            set;
        }
        public string TreatmentPlan
        {
            get;
            set;
        }
        public string AssignedStaff
        {
            get;
            set;
        }
    }
}
