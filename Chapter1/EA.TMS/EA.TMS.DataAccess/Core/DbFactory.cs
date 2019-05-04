namespace EA.TMS.DataAccess.Core
{
    using System;

    public class DbFactory : IDbFactory, IDisposable
    {

        private readonly DataContext _dataContext;
        public DbFactory(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public DataContext GetDataContext
        {
            get
            {
                return _dataContext;
            }
        }

        #region Disposing 

        private bool isDisposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                if (_dataContext != null)
                {
                    _dataContext.Dispose();
                }
            }
            isDisposed = true;
        }

        #endregion
    }
}