using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using UOM.Application.Contracts;

namespace UOM.Interface.Facade.Contracts
{
    public interface IDimensionFacade : IFacadeService
    {
        //[NeedPermission("X")]
        Guid Create(CreateDimensionCommand command);
    }
}
