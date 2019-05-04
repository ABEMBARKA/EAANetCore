namespace EA.TMS.BusinessLayer.Managers.ServiceRequestManagement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common.BusinessObjects;
    using Common.Core;
    using Common.Entities;
    using Core;
    using DataAccess.Core;
    using Microsoft.Extensions.Logging;

    public class ServiceRequestManager : BusinessManager, IServiceRequestManager
    {
        private readonly IRepository _repository;
        ILogger<ServiceRequestManager> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
        }

        public ServiceRequestManager(IRepository repository, ILogger<ServiceRequestManager> logger, IUnitOfWork unitOfWork) : base()
        {
            _repository = repository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public void Create(BaseEntity entity)
        {
            ServiceRequest serviceRequest = (ServiceRequest)entity;
            _logger.LogInformation("Creating record for {0}", this.GetType());
            _repository.Create<ServiceRequest>(serviceRequest);
            _logger.LogInformation("Record saved for {0}", this.GetType());
        }

        public void Delete(BaseEntity entity)
        {
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TenantServiceRequest> GetAllTenantServiceRequests()
        {

            var query = from tenants in _repository.All<Tenant>()
                        join serviceReqs in _repository.All<ServiceRequest>() on tenants.Id equals serviceReqs.TenantId
                        join status in _repository.All<Status>()
                        on serviceReqs.StatusId equals status.Id
                        select new TenantServiceRequest()
                        {
                            TenantId = tenants.Id,
                            Description = serviceReqs.Description,
                            Email = tenants.Email,
                            EmployeeComments = serviceReqs.EmployeeComments,
                            Phone = tenants.Phone,
                            Status = status.Description,
                            TenantName = tenants.Name
                        };
            return query.ToList<TenantServiceRequest>();
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }
    }
}