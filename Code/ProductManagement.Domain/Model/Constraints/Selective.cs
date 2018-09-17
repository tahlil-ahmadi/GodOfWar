using System.Collections.Generic;

namespace ProductManagement.Domain.Model.Constraints
{
    public class Selective : Constraint
    {
        public Dictionary<long,string> SelectiveList { get; set; }
    }
}

