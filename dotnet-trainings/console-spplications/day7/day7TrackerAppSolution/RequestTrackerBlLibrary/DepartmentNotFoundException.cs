using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class DepartmentNotFoundException : Exception
    {
        string msg;
        public DepartmentNotFoundException()
        {
        }

        public DepartmentNotFoundException(string? message) : base(message)
        {
            msg = "Department does not exist";
        }

        public DepartmentNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DepartmentNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}