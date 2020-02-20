using Microsoft.EntityFrameworkCore;

namespace MasterDetailApp.EF.Utility
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<T> Create<T>(DbContext db) where T : Entity
        {
            return new GenericRepository<T>(db);
        }
    }
}
