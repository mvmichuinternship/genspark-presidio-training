using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class DoctorFetchFailedException : Exception
    {
        string msg;
        public DoctorFetchFailedException()
        {
            msg = "Fetch failed";
        }

        public override string Message => msg;
    }
}