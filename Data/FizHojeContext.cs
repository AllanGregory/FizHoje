using FizHoje.Models;
using Microsoft.EntityFrameworkCore;

namespace FizHoje.Data
{
    public class FizHojeContext : DbContext
    {
        public FizHojeContext(DbContextOptions<FizHojeContext> opt) : base (opt)
        {
            
        }

        public DbSet<FizHojeModel> FizHoje { get; set; }
    }
}