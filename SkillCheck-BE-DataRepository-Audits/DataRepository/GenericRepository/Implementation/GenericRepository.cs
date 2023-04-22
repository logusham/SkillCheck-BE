using SkillCheck_BE_DataRepository_Audits.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SkillCheckDbContext _dbContext;

        public GenericRepository(SkillCheckDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<T> Get(int id) => await _dbContext.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public void Update(T entity)
        {
            _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
