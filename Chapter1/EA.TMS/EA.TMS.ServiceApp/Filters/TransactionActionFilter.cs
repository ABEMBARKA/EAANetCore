namespace EA.TMS.ServiceApp.Filters
{
    using Controllers;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.EntityFrameworkCore.Storage;

    public class TransactionActionFilter : ActionFilterAttribute
    {
        IDbContextTransaction transaction;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ((BaseController)context.Controller).ActionManager.UnitOfWork.BeginTransaction();

        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {

            if (context.Exception != null)
            {
                ((BaseController)context.Controller).ActionManager.UnitOfWork.RollbackTransaction();
            }
            else
            {
                ((BaseController)context.Controller).ActionManager.UnitOfWork.CommitTransaction();
            }
        }

    }
}