namespace EA.TMS.BusinessLayer.Managers.TenantManagement
{
    using Common.Entities;
    using Core;

    public interface ITenantManager : IActionManager
    {
        Tenant GetTenant(long tenantId);
    }
}