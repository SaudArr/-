using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TraineePro.Models;

namespace TraineePro.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Trainees> Trainees { get; set; }
        public DbSet<TestModel> TestModel { get; set; }
    }
}
