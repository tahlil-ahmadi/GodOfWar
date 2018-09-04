using System;

namespace ProductManagement.Domain.Model.Constraints
{
    public class DateRange : Constraint
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
