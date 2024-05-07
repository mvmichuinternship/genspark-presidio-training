using System.Runtime.Serialization;

namespace ClinicAppBlLibrary
{
    [Serializable]
    public class DuplicateTimeException : Exception
    {
        string msg;
        public DuplicateTimeException()
        {
            msg = "The time has already been scheduled";
        }

        //public DuplicateTimeException(string? message) 
        //{

        //}
        public override string Message => msg;

    }
}