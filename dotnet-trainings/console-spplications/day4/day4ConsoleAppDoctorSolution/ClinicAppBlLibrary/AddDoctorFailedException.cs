using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class AddDoctorFailedException : Exception
    {
        string msg;
        public AddDoctorFailedException()
        {
            msg = "Add operation Failed";
        }

        public override string Message => msg;
    }
}