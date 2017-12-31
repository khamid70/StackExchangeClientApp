using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackClient.StackExchange.Common;
using StackClient.StackExchange.Entity;
using StackClient.StackExchange.Repository.Common;

namespace StackClient.StackExchange.Repository
{
    public class AnswersRepository : IRepository<AnswerEntity>, IDisposable
    {
        #region Class Declarations

        private LoggingHandler _loggingHandler;
        private ConfigurationHandler _configurationHandler;
        private bool _bDisposed;

        #endregion

        #region Class Methods

        public AnswerEntity SelectItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AnswerEntity> SelectItemsFiltered()
        {
            throw new NotImplementedException();
        }

        public AnswersRepository()
        {
            _configurationHandler = new ConfigurationHandler();
            _loggingHandler = new LoggingHandler();
            UrlInitialFilter = _configurationHandler.StackApiUrl;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool bDisposing)
        {
            // Check to see if Dispose has already been called.
            if (!_bDisposed)
            {
                if (bDisposing)
                {
                    // Dispose managed resources.
                    _configurationHandler = null;
                    _loggingHandler = null;
                }
            }
            _bDisposed = true;
        }
        
        #endregion

        #region Class Properties

        public string UrlInitialFilter { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string Site { get; set; }
        public OrderType Order { get; set; }
        public SortType Sort { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        #endregion
    }
}
