using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M153_Project_Olma_Moiz_Jamalia.Models
{
    [Table("wrongAnswers")]
    public class WrongAnswers
    {
        [Key]
        public int? WrongAnswerID { get; set; }
        public int? FK_QuestionID { get; set; }
        public string? WrongAnswer1 { get; set; }
        public string? WrongAnswer2 { get; set; }
        public string? WrongAnswer3 { get; set; }
    }
}
