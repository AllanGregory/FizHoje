using System.Collections.Generic;
using FizHoje.Models;

namespace FizHoje.Data
{
    public interface IFizHojeRepo
    {
        bool SaveChanges();
        IEnumerable<FizHojeModel> GetAllFizHoje();
        FizHojeModel GetFizHojeById(int id);
        void CreateFizHoje(FizHojeModel fizHoje);
        void UpdateFizHoje(FizHojeModel fizHoje);
        void DeleteFizHoje(FizHojeModel fizHoje);
    }
}