using System;
using System.Collections.Generic;
using System.Configuration;
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
        public async Task<List<DimensionQuery>> GetAll()
        {
            //TODO: refactor this and inject connection manager
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var result =  await connection.QueryAsync<DimensionQuery>("SELECT * FROM Dimensions");
                return result.ToList();
            }
        }

        public async Task<DimensionQuery> GetById(Guid id)
        {
            //TODO: refactor this and inject connection manager
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                return await connection
                                .QueryFirstOrDefaultAsync<DimensionQuery>("SELECT * FROM Dimensions WHERE Id=@id", new {id= id});
            }
        }
    }
}
