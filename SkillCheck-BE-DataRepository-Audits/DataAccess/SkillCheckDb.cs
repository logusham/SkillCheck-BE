using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_Entities_Audits.EntitiesUpdated;

namespace SkillCheck_BE_DataRepository_Audits.DataAccess
{
    public class SkillCheckDb : DbContext
    {
        public SkillCheckDb(DbContextOptions<SkillCheckDb> options) : base(options)
        {

        }


        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AuditCheck> AuditChecks { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAuditCheck> UserAuditChecks { get; set; }

        

    }
}
