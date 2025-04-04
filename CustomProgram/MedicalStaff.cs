namespace HospitalManagementSystem
{
    public abstract class MedicalStaff : Person
    {
        protected MedicalStaff(string name, string contact, DateTime dob, string working_hours, string experience)
            : base(name, contact, dob)
        {
            WorkingHours = working_hours;
            Experience = experience;
        }

        public string WorkingHours 
        { 
            get;
            set; 
        }

        public string Experience 
        { 
            get; 
            set; 
        }

        public abstract void Diagnose();

        public abstract void ProvideTreatment();
    }
}

