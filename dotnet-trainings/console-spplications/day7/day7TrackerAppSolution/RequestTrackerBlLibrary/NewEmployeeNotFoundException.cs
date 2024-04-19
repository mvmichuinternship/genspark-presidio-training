using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class NewEmployeeNotFoundException : Exception
    {
        string msg;
        public NewEmployeeNotFoundException()
        {
        }

        public NewEmployeeNotFoundException(string? message) : base(message)
        {
            msg = "New Employee Not Found";
        }

        public NewEmployeeNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewEmployeeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}