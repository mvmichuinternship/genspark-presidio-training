using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class EmployeeNotFoundException : Exception
    {
        string msg;
        public EmployeeNotFoundException()
        {
        }

        public EmployeeNotFoundException(string? message) : base(message)
        {
            msg = "Employee Not Found";
        }

        public EmployeeNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmployeeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}