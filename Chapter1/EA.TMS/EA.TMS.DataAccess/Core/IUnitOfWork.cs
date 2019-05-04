namespace EA.TMS.DataAccess.Core
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        void BeginTransaction();
        void RollbackTransaction();
        void CommitTransaction();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}