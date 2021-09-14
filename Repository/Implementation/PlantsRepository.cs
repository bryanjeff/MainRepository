using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_API.Entities;

namespace PO_API.Repository.Implementation
{
    public class PlantsRepository: IPlantsRepository<Plant>
    {
        public POAPI_Context _poapi_Context;

        public PlantsRepository(POAPI_Context context)
        {
            _poapi_Context = context;
        }

        public IEnumerable<Plant> GetAllPlants()
        {
            return _poapi_Context.Plants.ToList();
        }
        public async Task<Plant> Create(Plant newplants)
        {
            //return _poapi_Context.Plants.ToList();
            var obj = await _poapi_Context.Plants.AddAsync(newplants);
            _poapi_Context.SaveChanges();
            return obj.Entity;
        }
    }
}
