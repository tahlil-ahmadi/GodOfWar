using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using UOM.Application;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController
    {
        private readonly IDimensionService _service;
        public DimensionsController(IDimensionService service)
        {
            _service = service;
        }

        public void Post(CreateDimensionDTO dto)
        {
            _service.Create(dto);    
        }
    }
}
