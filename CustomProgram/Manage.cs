namespace HospitalManagementSystem
{
    public class Manage
    {
        private List<PatientRecord> _patient_records = new List<PatientRecord>();
        private string _file_path = "E:/COS20007/CustomProgram/HospitalRecords.txt";


        public Manage()
        {
            LoadRecordsFromFile();
        }

        public void AddPatientRecord(Patient patient, string treatment_plan, string assigned_staff)
        {
            PatientRecord new_record = new PatientRecord(patient.Name, patient.DOB, patient.Contact, patient.Symptoms, treatment_plan, assigned_staff);

            _patient_records.Add(new_record);
            Console.WriteLine($"Patient record for {patient.Name} has been added.");

            SaveRecordsToFile();
        }

        public void RemovePatientRecord(Patient patient)
        {
            PatientRecord record_remove = _patient_records.Find(r => r.Name == patient.Name);

            if (record_remove != null)
            {
                _patient_records.Remove(record_remove);
                Console.WriteLine($"Patient record for {patient.Name} has been removed.");
                SaveRecordsToFile();
            }
            else
            {
                Console.WriteLine($"No patient record found for {patient.Name}.");
            }
        }

        public void DisplayAllRecords()
        {
            if (_patient_records.Count == 0)
            {
                Console.WriteLine("No patient records available.");
                return;
            }

            Console.WriteLine("Displaying all patient records:");
            foreach (var record in _patient_records)
            {
                record.DisplayRecord();
                Console.WriteLine();
            }
        }


        public PatientRecord FindPatientRecordByName(string patient_name)
        {
            return _patient_records.Find(r => r.Name == patient_name);
        }

        public void SaveRecordsToFile() // Make this public for external saving
        {
            using (StreamWriter writer = new StreamWriter(_file_path))
            {
                foreach (var record in _patient_records)
                {
                    writer.WriteLine(record.Name);
                    writer.WriteLine(record.DateOfBirth.ToString("yyyy-MM-dd"));
                    writer.WriteLine(record.Contact);
                    writer.WriteLine(string.Join(",", record.Symptoms));
                    writer.WriteLine(record.TreatmentPlan);
                    writer.WriteLine(record.AssignedStaff);
                }
            }
            Console.WriteLine("Records saved to file.");
        }

        private void LoadRecordsFromFile()
        {
            if (File.Exists(_file_path))
            {
                using (StreamReader reader = new StreamReader(_file_path))
                {
                    while (!reader.EndOfStream)
                    {
                        string name = reader.ReadLine();
                        DateTime dob = DateTime.Parse(reader.ReadLine());
                        string contact = reader.ReadLine();
                        string[] symptoms = reader.ReadLine().Split(',');
                        string treatment_plan = reader.ReadLine();
                        string assigned_staff = reader.ReadLine();

                        PatientRecord record = new PatientRecord(name, dob, contact, symptoms, treatment_plan, assigned_staff);
                        _patient_records.Add(record);
                    }
                }
                Console.WriteLine("Records loaded from file.");
            }
            else
            {
                Console.WriteLine("No records file found, starting fresh.");
            }
        }
    }
}
