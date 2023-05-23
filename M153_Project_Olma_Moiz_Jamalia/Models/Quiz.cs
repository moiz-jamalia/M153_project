using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M153_Project_Olma_Moiz_Jamalia.Models
{
    [Table("quiz")]
    public class Quiz
    {
        [Key]
        public int? QuizID { get; set; }
        public string? Question { get; set; }
        public string? CorrectAnswer { get; set; }
    }
}
