using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class DuplicateEmployeeNameException : Exception
    {
        public DuplicateEmployeeNameException()
        {
        }

        public DuplicateEmployeeNameException(string? message) : base(message)
        {
        }

        public DuplicateEmployeeNameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateEmployeeNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}