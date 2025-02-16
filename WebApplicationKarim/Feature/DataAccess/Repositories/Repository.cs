
namespace WebApplicationKarim.Feature.DataAccess.Repositories
{
    public class Repository<T>:IRepository<T> where T:class
    {
        protected readonly KarimDbContext _context;
        public Repository(KarimDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
           await _context.SaveChangesAsync();
        }
    }
}
