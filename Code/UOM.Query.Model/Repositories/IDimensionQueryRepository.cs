using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UOM.Query.Model.Models;

namespace UOM.Query.Model.Repositories
{
    public interface IDimensionQueryRepository
    {
        Task<List<DimensionQuery>> GetAll();
        Task<DimensionQuery> GetById(Guid id);
    }
}