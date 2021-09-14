using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_API.Repository;
using PO_API.Repository.Implementation;
using PO_API.Entities;

namespace PO_API.Controllers
{
    [Route("api/TargetSettings")]
    [ApiController]
    public class TargetSettingsController : ControllerBase
    {
        private readonly ITargetSettingsRepository<TargetSetting> _targetSettingRepository;
        public TargetSettingsController(ITargetSettingsRepository<TargetSetting> targetSettingRepositor)
        {
            _targetSettingRepository = targetSettingRepositor;
        }

        // GET: api/TargetSettings/GetAllTargetSettings  
        [HttpGet]
        [Route("GetAllTargetSettings")]
        public IActionResult GetAllTargetSettings()
        {
            IEnumerable<TargetSetting> alltargetsettings = _targetSettingRepository.GetAllTargetSettings();
            return Ok(alltargetsettings);
        }
    }
}
