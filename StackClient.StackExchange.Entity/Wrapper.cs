using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using StackClient.StackExchange.Entity.Common;

namespace StackClient.StackExchange.Entity
{
    [DataContract]
    public class Wrapper<TEntity> : IWrapperCollection<TEntity>, IDisposable where TEntity : class
    {
        #region Class Declarations

        #endregion

        #region Class Methods

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Class Properties

        [DataMember(Name = "items")]
        public List<TEntity> Items { get; set; }

        [DataMember(Name = "has_more")]
        public bool? HasMore { get; set; }

        [DataMember(Name = "quota_max")]
        public int? QuotaMax { get; set; }

        [DataMember(Name = "quota_remaining")]
        public int? QuotaRemaining { get; set; }

        [DataMember(Name = "total")]
        public int? Total { get; set; }

        #endregion
    }
}
