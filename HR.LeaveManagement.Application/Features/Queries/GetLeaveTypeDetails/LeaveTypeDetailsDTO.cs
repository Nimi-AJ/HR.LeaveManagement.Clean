using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.Queries.GetLeaveTypeDetails
{
    public class LeaveTypeDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int NumberOfDays { get; set; }
    }
}
