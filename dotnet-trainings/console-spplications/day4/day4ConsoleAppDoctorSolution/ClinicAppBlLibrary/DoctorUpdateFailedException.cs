using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class DoctorUpdateFailedException : Exception
    {
        string msg;
        public DoctorUpdateFailedException()
        {
            msg = "Update failed";
        }

        public override string Message => msg;
    }
}