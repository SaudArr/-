using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TraineePro.Models
{
    public class TestModel
    {
        [Key] // Primary Key Annotation
        public int TraineeID { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("الاسم الاول")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("اسم الاب")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("اسم الجد")]
        public string? ThirdName { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("اسم العائلة")]
        public  string? LastName { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("رقم الهوية")]
        public  string? NationalID { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("الرقم الجامعي")]
        public  string? UniversityID { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("البريد الإلكتروني")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("رقم الجوال")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("اسم الاب")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("الجنس")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("الجامعة")]
        public string? University { get; set; }

       
        [DisplayName("الكلية")]
        public string? Collage { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("التخصص")]
        public string? Major { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("تاريخ بداية التدريب")]
        public DateTime TrainingStartDate { get; set; }

        [Required(ErrorMessage = "حقل الزامي")]
        [DisplayName("تاريخ نهاية التدريب")]

        public DateTime TrainingEndDate { get; set; }

        // public int? Status { get; set; }  // Default value

    }
}
