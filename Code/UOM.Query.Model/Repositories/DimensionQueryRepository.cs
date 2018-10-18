using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using UOM.Query.Model.Models;

namespace UOM.Query.Model.Repositories
{
    public class DimensionQueryRepository : IDimensionQueryRepository
    {
        private readonly IDbConnection _connection;
        public DimensionQueryRepository(IDbConnection connection)
        {
            _connection = connection;
        }


        public async Task<List<DimensionQuery>> GetAll()
        {
            var result =  await _connection.QueryAsync<DimensionQuery>("SELECT * FROM Dimensions");
            return result.ToList();
        }

        public async Task<DimensionQuery> GetById(Guid id)
        {
            return await _connection.QueryFirstOrDefaultAsync<DimensionQuery>("SELECT * FROM Dimensions WHERE Id=@id", new {id= id});
        }
    }
}
