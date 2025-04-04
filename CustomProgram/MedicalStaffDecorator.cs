using HospitalManagementSystem;

public class MedicalStaffDecorator : MedicalStaff
{
    private MedicalStaff _medical_staff;
    private string _expertise;

    public MedicalStaffDecorator(MedicalStaff medical_staff, string expertise) : base(medical_staff.Name, medical_staff.Contact, medical_staff.DOB, medical_staff.WorkingHours, medical_staff.Experience)
    {
        _medical_staff = medical_staff;
        _expertise = expertise;
    }

    public override void Diagnose()
    {
        _medical_staff.Diagnose();
        Console.WriteLine($"Specialist in {_expertise} is diagnosing the patient.");
    }

    public override void ProvideTreatment()
    {
        _medical_staff.ProvideTreatment();
        Console.WriteLine($"Specialist in {_expertise} is providing treatment.");
    }
}
