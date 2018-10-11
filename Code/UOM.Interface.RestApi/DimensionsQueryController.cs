using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Framework.Application;
using Framework.Core;
using UOM.Application;
using UOM.Application.Contracts;
using UOM.Query.Model.Models;
using UOM.Query.Model.Repositories;

namespace UOM.Interface.RestApi
{
    public class DimensionsQueryController : ApiController, IGateway
    {
        private readonly IDimensionQueryRepository _repository;
        public DimensionsQueryController(IDimensionQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<DimensionQuery>> Get()
        {
            //TODO: use dto instead of query models
            return await _repository.GetAll();
        }

        public async Task<DimensionQuery> Get(Guid id)
        {
            //TODO: use dto instead of query models
            return await _repository.GetById(id);
        }
    }
}
