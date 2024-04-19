using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class DepartmentHeadNotFoundException : Exception
    {
        string msg;
        public DepartmentHeadNotFoundException()
        {
        }

        public DepartmentHeadNotFoundException(string? message) : base(message)
        {
            msg = "Department Head Not Found";
        }

        public DepartmentHeadNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DepartmentHeadNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}