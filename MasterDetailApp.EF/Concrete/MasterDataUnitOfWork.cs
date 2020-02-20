using MasterDetailApp.EF.Entities;
using MasterDetailApp.EF.Utility;

namespace MasterDetailApp.EF.Concrete
{
    public class MasterDetailUnitOfWork : IMasterDetailUnitOfWork
    {
        private MasterDetailContext _db;

        public IRepository<Article> ArticleRepository { get; private set; }
        public IRepository<Category> CategoryRepository { get; private set; }

        public MasterDetailUnitOfWork(MasterDetailContext db, IRepositoryFactory repositoryFactory)
        {
            _db = db;

            ArticleRepository = repositoryFactory.Create<Article>(db);
            CategoryRepository = repositoryFactory.Create<Category>(db);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
