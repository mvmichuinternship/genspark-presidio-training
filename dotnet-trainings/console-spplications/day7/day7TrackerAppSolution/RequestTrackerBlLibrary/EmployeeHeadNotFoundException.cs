using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class EmployeeHeadNotFoundException : Exception
    {
        string msg;
        public EmployeeHeadNotFoundException()
        {
        }

        public EmployeeHeadNotFoundException(string? message) : base(message)
        {
            msg = "Employee Role Not Found";
        }

        public EmployeeHeadNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmployeeHeadNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}