using dotnet.Context;
using dotnet.Repositories.Home;

namespace dotnet.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IHomeRepository? _homeRepository;
        public UnitOfWork(AppDbContext context)
        {
                _context = context; 
        }

        public IHomeRepository HomeRepository
        {
            get { return _homeRepository = _homeRepository ?? new HomeRepository(_context); }
        }

        public void Commit()
        {
            _context.SaveChangesAsync();    
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }       
    }
}
