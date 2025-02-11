using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TraineePro.Models
{
    public class Trainees
    {
        [Key] // Primary Key Annotation
        public int TraineeID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; } 

        [Required(ErrorMessage = "Middle name is required")]
        public string? MiddleName { get; set; } 

        [Required(ErrorMessage = "Third name is required")]
        public string? ThirdName { get; set; } 

        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; } 

        [Required(ErrorMessage = "National ID is required")]
        public string? NationalID { get; set; } 

        [Required(ErrorMessage = "Birth date is required")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string? Gender { get; set; } 

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; } 

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; } 

        [Required(ErrorMessage = "Educational Institution is required")]
        public string? EducationalInstitution { get; set; } 

        [Required(ErrorMessage = "University ID is required")]
        public int UniversityID { get; set; }

        [Required(ErrorMessage = "College is required")]
        public string? College { get; set; } 

        [Required(ErrorMessage = "Major is required")]
        public string? Major { get; set; } 

        [Required(ErrorMessage = "Create date is required")]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Training start date is required")]
        [DataType(DataType.Date)]
        public DateTime TrainingStartDate { get; set; }

        [Required(ErrorMessage = "Training end date is required")]
        [DataType(DataType.Date)]
        public DateTime TrainingEndDate { get; set; }

        [NotMapped] // Exclude from database mapping
        [Required(ErrorMessage = "Training letter is required")]
        public string? TrainingLetter { get; set; }

        public string? TrainingLetterPath { get; set; } // Path to the uploaded file

        public string? Status { get; set; } = "Pending"; // Default status
    }
}