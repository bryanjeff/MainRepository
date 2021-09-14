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
    [Route("api/TargetSettingsSummary")]
    [ApiController]
    public class TargetSettingsSummaryController : ControllerBase
    {
        private readonly ITargetSettingsSummaryRepository<TargetSettingSumary> _targetSettingSummaryRepository;
        public TargetSettingsSummaryController(ITargetSettingsSummaryRepository<TargetSettingSumary> targetSettingSummaryRepository)
        {
            _targetSettingSummaryRepository = targetSettingSummaryRepository;
        }

        // GET: api/TargetSettingsSummary/GetAllTargetSettingsSummary  
        [HttpGet]
        [Route("GetAllTargetSettingsSummary")]
        public IActionResult GetAllTargetSettingsSummary()
        {
            IEnumerable<TargetSettingSumary> alltargetsettingssummary = _targetSettingSummaryRepository.GetAllTargetSettingsSummary();
            return Ok(alltargetsettingssummary);
        }
    }
}
