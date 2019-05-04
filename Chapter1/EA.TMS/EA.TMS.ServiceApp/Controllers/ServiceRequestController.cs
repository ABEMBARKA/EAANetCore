using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EA.TMS.ServiceApp.Controllers
{
    using BusinessLayer.Managers.ServiceRequestManagement;
    using Common.BusinessObjects;
    using Common.Entities;
    using Filters;
    using Microsoft.Extensions.Logging;

    [LoggingActionFilter]
    [Route("api/[controller]")]
    public class ServiceRequestController : BaseController
    {
        private readonly IServiceRequestManager _manager;
        private readonly ILogger<ServiceRequestController> _logger;

        public ServiceRequestController(IServiceRequestManager manager, ILogger<ServiceRequestController> logger) : base(manager, logger)
        {
            _manager = manager;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<TenantServiceRequest> GetTenantsRequests()
        {
            return _manager.GetAllTenantServiceRequests();
        }

        // POST api/values
        [HttpPost]
        public void Post(ServiceRequest serviceRequest)
        {
            try
            {
                _manager.Create(serviceRequest);
            }
            catch (Exception ex)
            {
                throw LogException(ex);
            }

        }
    }
}