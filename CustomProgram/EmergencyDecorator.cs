using HospitalManagementSystem;

public class EmergencyDecorator : MedicalStaff
{
    private MedicalStaff _medical_staff;

    public EmergencyDecorator(MedicalStaff medical_staff) : base(medical_staff.Name, medical_staff.Contact, medical_staff.DOB, medical_staff.WorkingHours, medical_staff.Experience)
    {
        _medical_staff = medical_staff;
    }

    public override void Diagnose()
    {
        _medical_staff.Diagnose();
        Console.WriteLine("Emergency handling diagnosis.");
    }

    public override void ProvideTreatment()
    {
        _medical_staff.ProvideTreatment();
        Console.WriteLine("Emergency treatment provided.");
    }
}
