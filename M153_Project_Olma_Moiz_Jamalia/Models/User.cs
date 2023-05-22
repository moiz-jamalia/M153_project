using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M153_Project_Olma_Moiz_Jamalia.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Birthdate is required.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? EMail { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public string? PhoneNr { get; set; }

        [Required(ErrorMessage = "Post Code is required.")]
        public string? PostCode { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        public string? Street { get; set; }

        [Required(ErrorMessage = "Street Number is required.")]
        public int StreetNr { get; set; }

        [Required(ErrorMessage = "Image is required.")]
        public byte[]? Image { get; set; }

        [Required(ErrorMessage = "Correct Answer is required.")]
        public bool CorrectAnswer { get; set; }
    }
}
