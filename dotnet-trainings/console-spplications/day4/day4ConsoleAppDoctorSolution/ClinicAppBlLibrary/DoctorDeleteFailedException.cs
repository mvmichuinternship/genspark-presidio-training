using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class DoctorDeleteFailedException : Exception
    {
        string msg;
        public DoctorDeleteFailedException()
        {
            msg = "Delete operation failed";
        }

        public override string Message => msg;
    }
}