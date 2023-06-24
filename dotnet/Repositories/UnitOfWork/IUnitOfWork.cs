using dotnet.Repositories.Home;

namespace dotnet.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        // our repositories here
        IHomeRepository HomeRepository { get; }  
        void Commit();
        void Dispose();
    }
}
