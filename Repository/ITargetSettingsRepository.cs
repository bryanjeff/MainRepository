using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PO_API.Repository
{
    public interface ITargetSettingsRepository<T>
    {
        IEnumerable<T> GetAllTargetSettings();
    }
}
