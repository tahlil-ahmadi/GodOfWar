using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Tests.Acceptance.Model;

namespace UOM.Tests.Acceptance.Tasks
{
    internal class DimensionTasks
    {
        internal bool DefineDimension(DimensionTestModel model)
        {
            //TODO: refactor 
            var client = new RestClient("http://localhost:20070/api");
            var request = new RestRequest("Dimensions", Method.POST);
            request.AddObject(model);
            var response = client.Execute(request);
            return response.IsSuccessful;
        }

        internal DimensionTestModel GetDimension(Guid id)
        {
            //TODO: refactor 
            var client = new RestClient("http://localhost:20070/api");
            var request = new RestRequest($"Dimensions/{id}", Method.GET);
            var data =  client.Execute<DimensionTestModel>(request).Data;
            return data;
        }
    }
}
