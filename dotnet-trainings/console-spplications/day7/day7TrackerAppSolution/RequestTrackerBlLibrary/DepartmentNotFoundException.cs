using System.Runtime.Serialization;

namespace RequestTrackerBlLibrary
{
    [Serializable]
    public class DepartmentNotFoundException : Exception
    {
        string msg;
        public DepartmentNotFoundException()
        {
            msg = "No Department with such name";
        }

        public DepartmentNotFoundException(string name)
        {
            msg = $"No Department with name {name}";
        }
        public override string Message => msg;
    }
}