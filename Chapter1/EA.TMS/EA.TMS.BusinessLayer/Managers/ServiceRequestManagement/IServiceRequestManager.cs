namespace EA.TMS.BusinessLayer.Managers.ServiceRequestManagement
{
    using System.Collections.Generic;
    using Common.BusinessObjects;
    using Core;

    public interface IServiceRequestManager : IActionManager
    {
        IEnumerable<TenantServiceRequest> GetAllTenantServiceRequests();
    }
}