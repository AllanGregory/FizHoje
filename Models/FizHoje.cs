using System.ComponentModel.DataAnnotations;

namespace FizHoje.Models
{
    public class FizHojeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool TaFeito { get; set; }
        
        [Required]
        public string DataFeito { get; set; }
    }
}