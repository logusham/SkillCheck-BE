using Master;
using Microsoft.EntityFrameworkCore;
using SkillCheck.Models.Accounts;
using SkillCheck.Models.Audits;
using SkillCheck.Models.Entitys;

namespace SkillCheck.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Batch> Batche { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Audit> Audit { get; set; }
        public DbSet<Technology> Technologie { get; set; }

    }
}
