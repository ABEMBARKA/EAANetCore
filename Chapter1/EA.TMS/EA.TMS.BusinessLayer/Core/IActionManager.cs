namespace EA.TMS.BusinessLayer.Core
{
    using System.Collections.Generic;
    using Common.Core;
    using DataAccess.Core;

    public interface IActionManager
    {
        void Create(BaseEntity entity);
        void Update(BaseEntity entity);
        void Delete(BaseEntity entity);
        IEnumerable<BaseEntity> GetAll();
        IUnitOfWork UnitOfWork { get; }
        void SaveChanges();
    }

}