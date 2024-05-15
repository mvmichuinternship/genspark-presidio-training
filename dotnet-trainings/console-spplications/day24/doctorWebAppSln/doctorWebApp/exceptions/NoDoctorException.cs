namespace doctorWebApp.exceptions
{
    public class NoDoctorException: Exception
    {
        string message;
        public NoDoctorException()
        {
            message = "No such doctor present";
        }

        public override string Message => message;
    }
}
