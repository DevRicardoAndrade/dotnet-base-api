using dotnet.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace dotnet.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context; 
        public Repository(AppDbContext context)
        {
                _context = context; 
        }
        public void Create(T model)
        {
            _context.Set<T>().Add(model);   
        }

        public void Delete(T model)
        {
            _context.Set<T>().Remove(model);
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsNoTracking();  
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(predicate); 
        }

        public void Update(T model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.Set<T>().Update(model); 
        }
    }
}
