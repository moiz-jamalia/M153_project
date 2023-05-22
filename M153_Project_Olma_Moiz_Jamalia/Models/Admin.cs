using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M153_Project_Olma_Moiz_Jamalia.Models
{
    [Table("admin")]
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string? Password { get; set; }
    }
}
