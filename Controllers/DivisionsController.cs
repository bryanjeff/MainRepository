using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_API.Repository;
using PO_API.Repository.Implementation;
using PO_API.Entities;
using PO_API.AzureLogicApp;

namespace PO_API.Controllers
{
    [Route("api/Divisions")]
    [ApiController]
    public class DivisionsController : ControllerBase
    {
        InitiateLogicApps logicAppCaller = new InitiateLogicApps();
        private readonly IDivisionRepository<Division> _divisionRepository;
        public DivisionsController(IDivisionRepository<Division> divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }

        // GET: api/Divisions/GetAllDivisions  
        [HttpGet]
        [Route("GetAllDivisions")]
        public IActionResult GetAllDivisions()
        {
            IEnumerable<Division> alldivisions = _divisionRepository.GetAllDivisions();
            return Ok(alldivisions);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<Division> Create(Division newdivision)
        {
            DivisionForNotif divNotif = new DivisionForNotif();
            if (newdivision == null)
            {
                throw new ArgumentNullException(nameof(newdivision));
            }
            divNotif.Request = "CreateDivision";
            divNotif.RequestValue = newdivision;
            logicAppCaller.TriggerCreateNotif(divNotif);
            return await _divisionRepository.Create(newdivision);
        }
    }
}
