namespace HospitalManagementSystem
{
    public class Receptionist : Person
    {
        public Receptionist(string name, string contact, DateTime dob):base(name, contact, dob) 
        { 
        }

        public void AddPatientRecord()
        {
            Console.WriteLine($"{Name} is adding a patient record to the system.");
        }
    }
}
