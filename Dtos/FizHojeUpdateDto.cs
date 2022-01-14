using System.ComponentModel.DataAnnotations;

namespace FizHoje.Dtos
{
    public class FizHojeUpdateDto
    {
        [Required]
        public bool TaFeito { get; set; }

        [Required]
        public string DataFeito { get; set; }
    }
}