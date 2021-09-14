using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_API.Entities;

namespace PO_API.Repository.Implementation
{
    public class TargetSettingsRepository: ITargetSettingsRepository<TargetSetting>
    {
        readonly POAPI_Context _poapi_Context;

        public TargetSettingsRepository(POAPI_Context context)
        {
            _poapi_Context = context;
        }

        public IEnumerable<TargetSetting> GetAllTargetSettings()
        {
            return _poapi_Context.TargetSettings.ToList();
        }

    }


}
