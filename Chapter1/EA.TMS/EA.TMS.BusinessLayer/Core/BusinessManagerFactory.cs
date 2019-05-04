namespace EA.TMS.BusinessLayer.Core
{
    using Managers.ServiceRequestManagement;
    using Managers.TenantManagement;

    public class BusinessManagerFactory
    {
        IServiceRequestManager _serviceRequestManager;
        ITenantManager _tenantManager;
        public BusinessManagerFactory(IServiceRequestManager serviceRequestManager = null, ITenantManager tenantManager = null)
        {
            _serviceRequestManager = serviceRequestManager;
            _tenantManager = tenantManager;
        }

        public IServiceRequestManager GetServiceRequestManager()
        {
            return _serviceRequestManager;
        }

        public ITenantManager GetTenantManager()
        {
            return _tenantManager;
        }

    }
}