using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M153_Project_Olma_Moiz_Jamalia.Models
{
    [Table("prize")]
    public class Prize
    {
        [Key]
        public int? PrizeID { get; set; }
        public string? Name { get; set; }
        public int? Amount { get; set; }
        public float? Worth { get; set; }
        public string? Currency { get; set; }
    }
}
