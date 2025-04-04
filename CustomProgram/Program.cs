using HospitalManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        Manage hospital_manager = new Manage();
        MedicalStaffFactory staff_factory = new MedicalStaffFactory();
        Receptionist receptionist = new Receptionist("Alice", "1234567890", new DateTime(1990, 5, 12));
        SurgicalNurse surgical_nurse = new SurgicalNurse("Nurse Mary", "4567891230", new DateTime(1982, 4, 15), "9 AM - 5 PM", "10 years");

        while (true)
        {
            Console.WriteLine("\nWelcome to the Hospital Management System");
            Console.WriteLine("1 - Add Patient Record");
            Console.WriteLine("2 - Remove Patient Record");
            Console.WriteLine("3 - Edit Patient Record");
            Console.WriteLine("4 - Display All Patient Records");
            Console.WriteLine("5 - Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Date of Birth (yyyy-mm-dd): ");
                    string input = Console.ReadLine();
                    DateTime dob;
                    if (DateTime.TryParse(input, out dob))
                    {
                        dob.ToShortDateString();
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please enter the date in the format yyyy/mm/dd.");
                    }

                    Console.Write("Contact Number: ");
                    string contact = Console.ReadLine();

                    Console.WriteLine("Please enter your symptoms (comma-separated): ");
                    string[] symptoms = Console.ReadLine().Split(',');

                    Patient patient1 = new Patient(name, dob, contact, symptoms);
                    

                    // Notify observers (Doctor) about the new patient record
                    Doctor doctor = new Doctor("Dr. Smith", "9876543210", new DateTime(1970, 6, 15), "9 AM - 5 PM", "15 years");
                    patient1.AttachObserver(doctor);  // Attach observer to patient

                    Console.WriteLine("Your information has been added to the hospital records.");

                    Console.WriteLine("Please select a treatment plan: 1 - Mild, 2 - Aggressive");
                    int treatment_plan_choice;
                    while (!int.TryParse(Console.ReadLine(), out treatment_plan_choice) || (treatment_plan_choice != 1 && treatment_plan_choice != 2))
                    {
                        Console.WriteLine("Invalid input. Please choose either 1 (Mild) or 2 (Aggressive): ");
                    }

                    TreatmentPlan treatment_plan;
                    MedicalStaff assigned_staff;

                    // Strategy and Factory Patterns: Based on the treatment plan, assign the appropriate medical staff
                    if (treatment_plan_choice == 1)
                    {
                        treatment_plan = new MildTreatment();
                        assigned_staff = staff_factory.CreateStaff("PediatricNurse", "Nurse Nina", "7890123456", new DateTime(1985, 3, 21), "9 AM - 5 PM", "10 years");
                        hospital_manager.AddPatientRecord(patient1, treatment_plan.ExecuteTreatment(patient1), assigned_staff.Name);
                    }
                    else
                    {
                        treatment_plan = new AggressiveTreatment();
                        assigned_staff = staff_factory.CreateStaff("Surgeon", "Dr. John", "9876543210", new DateTime(1975, 3, 10), "24/7", "15 years");
                        hospital_manager.AddPatientRecord(patient1, treatment_plan.ExecuteTreatment(patient1), assigned_staff.Name);
                    }

                    // Decorator Pattern: Add special abilities or expertise to the assigned medical staff
                    assigned_staff = new MedicalStaffDecorator(assigned_staff, "Cardiology Expertise");

                    // Display the assigned staff and begin treatment
                    Console.WriteLine($"You have been assigned to: {assigned_staff.GetType().Name} {assigned_staff.Name}");
                    Console.WriteLine("Your treatment plan is: " + treatment_plan.ExecuteTreatment(patient1));

                    // The assigned staff provides diagnosis and treatment
                    assigned_staff.Diagnose();
                    assigned_staff.ProvideTreatment();

                    // Update the patient record and notify doctor (Observer Pattern)
                    patient1.Notify();


                    

                    break;
                case "2":
                    Console.Write("Enter the patient's name to remove: ");
                    string name_to_remove = Console.ReadLine();
                    hospital_manager.RemovePatientRecord(new Patient(name_to_remove, DateTime.MinValue, "", null));
                    break;

                case "3":
                    Console.Write("Enter the patient's name to edit: ");
                    string name_to_edit = Console.ReadLine();

                    Console.Write("New Contact Number: ");
                    string new_contact = Console.ReadLine();

                    Console.WriteLine("New Symptoms (comma-separated): ");
                    string[] new_symptoms = Console.ReadLine().Split(',');


                    surgical_nurse.UpdatePatientRecord(hospital_manager, name_to_edit, new_contact, new_symptoms);
                    break;

                case "4":
                    hospital_manager.DisplayAllRecords();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
