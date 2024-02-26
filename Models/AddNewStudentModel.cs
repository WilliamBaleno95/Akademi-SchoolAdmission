namespace Akademi_SchoolAdmission.Models
{
    public class AddNewStudentModel
    {
        //--------------------------Student Details---------------------------------------
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentPhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? StudentAddress { get; set; }

        //---------------------------Parent Details----------------------------------------

        public string? ParentFirstName { get; set; }
        public string? ParentLastName { get; set;}
        public string? ParentEmail { get; set;}
        public string? ParentPhone { get; set;}
        public string? ParentAddress { get; set; }
        public bool? PaymentsCash { get; set; }
        public bool? PaymentsDebit { get; set;}
    }
}
