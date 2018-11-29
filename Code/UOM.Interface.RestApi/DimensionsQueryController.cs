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
            var user = this.User;
            //TODO: use dto instead of query models
            return await _repository.GetAll();
        }

        public DimensionQuery Get(Guid id)
        {
            var x = User;
            return new DimensionQuery() { Id = id, Name = "X" };
            //TODO: use dto instead of query models
            //return await _repository.GetById(id);
        }
    }
}
