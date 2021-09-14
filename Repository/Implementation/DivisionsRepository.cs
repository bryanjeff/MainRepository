using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PO_API.Entities;

namespace PO_API.Repository.Implementation
{
    public class DivisionsRepository: IDivisionRepository<Division>
    {
        readonly POAPI_Context _poapi_Context;

        public DivisionsRepository(POAPI_Context context)
        {
            _poapi_Context = context;
        }

        public IEnumerable<Division> GetAllDivisions()
        {
            return _poapi_Context.Divisions.ToList();
        }

        public async Task<Division> Create(Division newdivision)
        {
            //return _poapi_Context.Plants.ToList();
            var obj = await _poapi_Context.Divisions.AddAsync(newdivision);
            _poapi_Context.SaveChanges();
            return obj.Entity;
        }
    }
}
