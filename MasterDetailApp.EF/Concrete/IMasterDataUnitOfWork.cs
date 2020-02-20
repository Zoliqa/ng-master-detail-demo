using MasterDetailApp.EF.Entities;
using MasterDetailApp.EF.Utility;

namespace MasterDetailApp.EF.Concrete
{
    public interface IMasterDetailUnitOfWork : IUnitOfWork
    {
        IRepository<Article> ArticleRepository { get; }
        IRepository<Category> CategoryRepository { get; }
    }
}
