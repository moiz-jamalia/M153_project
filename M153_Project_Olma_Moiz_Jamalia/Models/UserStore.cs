using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M153_Project_Olma_Moiz_Jamalia.Models
{
    [Table("user")]
    public class UserStore
    {
        [Key]
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? EMail { get; set; }
        public string? PhoneNr { get; set; }
        public string? PostCode { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int? StreetNr { get; set; }
        public byte[]? Image { get; set; }
        public bool? CorrectAnswer { get; set; }
    }
}
