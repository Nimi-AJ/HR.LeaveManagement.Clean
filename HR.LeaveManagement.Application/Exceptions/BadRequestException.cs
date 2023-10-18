using FluentValidation.Results;

namespace HR.LeaveManagement.Application.Exceptions
{
    [Serializable]
    public class BadRequestException : Exception
    {
        public BadRequestException() { }
        public BadRequestException(string message, ValidationResult validationResult) : base(message) { 
            ValidationErrors = new List<string>();
            foreach(var error in validationResult.Errors)
            {
                ValidationErrors.Add(error.ErrorMessage);
            }
        }
        public BadRequestException(string message, Exception inner) : base(message, inner) { }

        private List<string> ValidationErrors { get; set; }

    }
}
