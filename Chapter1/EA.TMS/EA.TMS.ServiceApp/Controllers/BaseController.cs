using System;
using Microsoft.AspNetCore.Mvc;

namespace EA.TMS.ServiceApp.Controllers
{
    using System.Net.Http;
    using System.Web.Http;
    using Common.Facade;
    using EA.TMS.BusinessLayer.Core;
    using Microsoft.Extensions.Logging;

    public class BaseController : Controller
    {
        private readonly IActionManager _manager;
        private readonly ILogger _logger;
        public BaseController(IActionManager manager, ILogger logger)
        {
            _manager = manager;
            _logger = logger;
        }
        public IActionManager ActionManager { get { return _manager; } }
        public ILogger Logger { get { return _logger; } }
        public HttpResponseException LogException(Exception ex)
        {
            string errorMessage = LoggerHelper.GetExceptionDetails(ex);
            _logger.LogError(LoggingEvents.SERVICE_ERROR, ex, errorMessage);
            HttpResponseMessage message = new HttpResponseMessage();
            message.Content = new StringContent(errorMessage);
            message.StatusCode = System.Net.HttpStatusCode.ExpectationFailed;
            throw new HttpResponseException(message);
        }

    }
}