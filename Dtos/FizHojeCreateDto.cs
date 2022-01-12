using System.ComponentModel.DataAnnotations;

namespace FizHoje.Dtos
{
    public class FizHojeCreateDto
    {
        public bool TaFeito { get; set; }
        public string DataFeito { get; set; }
    }
}