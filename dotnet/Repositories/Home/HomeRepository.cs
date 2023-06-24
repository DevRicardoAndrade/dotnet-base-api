using dotnet.Context;
using dotnet.Models;

namespace dotnet.Repositories.Home
{
    public class HomeRepository : Repository<HomeModel>, IHomeRepository
    {
        public HomeRepository(AppDbContext  context) : base(context)
        {
            
        }
    }
}
