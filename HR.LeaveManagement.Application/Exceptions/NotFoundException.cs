using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException() { }
        public NotFoundException(string message, object key) : base($"{message} ({key}) was not found") { }
        public NotFoundException(string message, Exception inner) : base(message, inner) { }
        
    }
}
