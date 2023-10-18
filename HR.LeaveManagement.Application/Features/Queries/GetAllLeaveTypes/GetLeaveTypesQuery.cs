using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.Queries.GetAllLeaveTypes
{
    public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDTO>>
    {

    }
}
