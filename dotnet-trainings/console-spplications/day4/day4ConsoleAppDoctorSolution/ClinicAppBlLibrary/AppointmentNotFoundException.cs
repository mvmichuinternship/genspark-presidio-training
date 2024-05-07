using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class AppointmentNotFoundException : Exception
    {
        string msg;
        public AppointmentNotFoundException()
        {
            msg = "Appointment not found";
        }

        public override string Message => msg;
    }
}