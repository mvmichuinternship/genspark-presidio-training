using Microsoft.VisualBasic;
using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class AppointmentDeleteFailedException : Exception
    {
        string msg;
        public AppointmentDeleteFailedException()
        {
            msg = "Faild to delete appointment";
        }

        public override string Message => msg;
    }
}