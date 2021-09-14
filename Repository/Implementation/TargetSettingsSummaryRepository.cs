using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_API.Entities;

namespace PO_API.Repository.Implementation
{
    public class TargetSettingsSummaryRepository: ITargetSettingsSummaryRepository<TargetSettingSumary>
    {
        readonly POAPI_Context _poapi_Context;

        public TargetSettingsSummaryRepository(POAPI_Context context)
        {
            _poapi_Context = context;
        }

        public IEnumerable<TargetSettingSumary> GetAllTargetSettingsSummary()
        {
            return _poapi_Context.TargetSettingSumaries.ToList();
        }
    }
}
