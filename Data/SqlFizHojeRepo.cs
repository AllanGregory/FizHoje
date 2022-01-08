using System.Collections.Generic;
using System.Linq;
using FizHoje.Models;

namespace FizHoje.Data
{
    public class SqlFizHojeRepo : IFizHojeRepo
    {
        private readonly FizHojeContext _context;

        public SqlFizHojeRepo(FizHojeContext context)
        {
            _context = context;
        }

        public void CreateFizHoje(FizHojeModel fizHoje)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFizHoje(FizHojeModel fizHoje)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FizHojeModel> GetAllFizHoje()
        {
            return _context.FizHoje.ToList();
        }

        public FizHojeModel GetFizHojeById(int id)
        {
            return _context.FizHoje.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFizHoje(FizHojeModel fizHoje)
        {
            throw new System.NotImplementedException();
        }
    }
}