namespace HospitalManagementSystem
{
    public abstract class Person
    {
        protected Person(string name, string contact, DateTime dob)
        {
            Name = name;
            Contact = contact;
            DOB = dob;
        }

        public string Name 
        { 
            get; 
            set; 
        }

        public string Contact 
        { 
            get;
            set; 
        }

        public DateTime DOB 
        { 
            get; 
            set; 
        }

    }
}

