namespace HospitalManagementSystem
{
    public class MedicalStaffFactory
    {
        public MedicalStaff CreateStaff(string type, string name, string contact, DateTime dob, string working_hours, string experience)
        {
            switch (type)
            {
                case "SurgicalNurse":
                    return new SurgicalNurse(name, contact, dob, working_hours, experience);
                case "Surgeon":
                    return new Surgeon(name, contact, dob, working_hours, experience);
                case "Pediatrician":
                    return new Pediatric(name, contact, dob, working_hours, experience);
                case "EmergencyNurse":
                    return new EmergencyNurse(name, contact, dob, working_hours, experience);
                case "PediatricNurse":
                    return new PediatricNurse(name, contact, dob, working_hours, experience);
                case "Psychologist":
                    return new Psychologist(name, contact, dob, working_hours, experience);
                default:
                    throw new ArgumentException("Invalid staff type");
            }
        }
    }
}
