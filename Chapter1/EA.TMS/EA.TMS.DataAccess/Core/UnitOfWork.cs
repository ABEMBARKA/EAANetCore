namespace EA.TMS.DataAccess.Core
{
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public void BeginTransaction()
        {
            _dbFactory.GetDataContext.Database.BeginTransaction();
        }
        public void RollbackTransaction()
        {
            _dbFactory.GetDataContext.Database.RollbackTransaction();
        }
        public void CommitTransaction()
        {
            _dbFactory.GetDataContext.Database.CommitTransaction();
        }
        public void SaveChanges()
        {
            _dbFactory.GetDataContext.Save();
        }
        public Task SaveChangesAsync()
        {
           return _dbFactory.GetDataContext.SaveChangesAsync();
        }
    }
}