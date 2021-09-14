using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PO_API.Repository
{
    public interface IDivisionRepository<T>
    {
        IEnumerable<T> GetAllDivisions();
        public Task<T> Create(T _object);
    }
}
