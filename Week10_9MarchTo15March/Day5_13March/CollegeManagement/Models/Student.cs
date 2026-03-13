using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagement.Models
{
    [Table("tblStudents")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public double Marks10 { get; set; }
        public double Marks12 { get; set; }
        public bool CertificateSubmitted { get; set; }
        public bool FeesPaid { get; set; }
        public bool HasDue { get; set; }
        public double MSTMarks { get; set; }
        public bool AdmissionApproved { get; set; }

        public void CheckAdmission()
        {
            if (Marks10 >= 40 && Marks12 >= 40 && CertificateSubmitted)
                AdmissionApproved = true;
            else
                AdmissionApproved = false;
        }

        public bool CheckFinalEligibility()
        {
            if (!AdmissionApproved) return false;
            if (!FeesPaid) return false;
            if (HasDue) return false;
            if (MSTMarks < 40) return false;

            return true;
        }
    }
}