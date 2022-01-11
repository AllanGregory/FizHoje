using System.ComponentModel.DataAnnotations;

namespace FizHoje.Dtos
{
    public class FizHojeReadDto
    {
        //public int Id { get; set; }
        public bool TaFeito { get; set; }
        public string DataFeito { get; set; }
    }
}