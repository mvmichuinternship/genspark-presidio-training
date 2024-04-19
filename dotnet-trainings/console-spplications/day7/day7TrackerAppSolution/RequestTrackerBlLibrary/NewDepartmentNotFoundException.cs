using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    internal class NewDepartmentNotFoundException : Exception
    {
        string msg;
        public NewDepartmentNotFoundException()
        {
        }

        public NewDepartmentNotFoundException(string? message) : base(message)
        {
            msg = "NewDepartmentNotFound";
        }

        public NewDepartmentNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NewDepartmentNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}