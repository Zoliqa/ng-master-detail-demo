using Microsoft.EntityFrameworkCore;

namespace MasterDetailApp.EF.Utility
{
    public interface IRepositoryFactory
    {
        IRepository<T> Create<T>(DbContext db) where T : Entity;
    }
}
