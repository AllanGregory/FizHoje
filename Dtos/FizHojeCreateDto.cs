using System.ComponentModel.DataAnnotations;

namespace FizHoje.Dtos
{
    public class FizHojeCreateDto
    {
        [Required]
        public bool TaFeito { get; set; }

        [Required]
        public string DataFeito { get; set; }
    }
}