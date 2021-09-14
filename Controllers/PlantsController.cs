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
    [Route("api/Plants")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        InitiateLogicApps logicAppCaller = new InitiateLogicApps();
        private readonly IPlantsRepository<Plant> _plantRepository;
        public PlantsController(IPlantsRepository<Plant> plantRepository)
        {
            _plantRepository = plantRepository;
        }

        // GET: api/Plants/GetAllPlants  
        [HttpGet]
        [Route("GetAllPlants")]
        public IActionResult GetAllPlants()
        {
            IEnumerable<Plant> allplants = _plantRepository.GetAllPlants();
            return Ok(allplants);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<Plant> Create (Plant newplants){
            PlantForNotif plantNotif = new PlantForNotif();        
            if (newplants == null) {
                throw new ArgumentNullException(nameof(newplants));
            }
            plantNotif.Request = "CreatePlants";
            plantNotif.RequestValue = newplants;

            logicAppCaller.TriggerCreateNotif(plantNotif);
            return await _plantRepository.Create(newplants);
        }
    }
}
