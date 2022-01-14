using System;
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
            if (fizHoje == null)
            {
                throw new ArgumentNullException(nameof(fizHoje));
            }

            _context.FizHoje.Add(fizHoje);
        }

        public void DeleteFizHoje(FizHojeModel fizHoje)
        {
            if (fizHoje == null)
            {
                 throw new ArgumentNullException(nameof(fizHoje));
            }

            _context.FizHoje.Remove(fizHoje);
        }

        public IEnumerable<FizHojeModel> GetAllFizHoje()
        {
            return _context.FizHoje.ToList();
        }

        public FizHojeModel GetFizHojeById(int id)
        {
            return _context.FizHoje.FirstOrDefault(p => p.Id == id);
        }

        //Esse método faz que as alterações no banco de dados aconteçam de fato
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateFizHoje(FizHojeModel fizHoje)
        {
            //Não faz nada
        }
    }
}