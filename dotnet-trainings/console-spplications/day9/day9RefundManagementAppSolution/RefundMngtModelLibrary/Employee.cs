namespace RefundMngtModelLibrary
{
    public class Employee
    {
        int age;
        DateTime dob;

        /// <summary>
        /// Sets the employee ID and returns the same
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Sets Employee name and returns the same. Initialised to empty string.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// returns age 
        /// Age is calculated using data from dob
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }
        }
        /// <summary>
        /// Getting dob and setting both dob and calculating age
        /// </summary>
        public DateTime DateOfBirth
        {
            get => dob;
            set
            {
                dob = value;
                age = ((DateTime.Today - dob).Days) / 365;
            }
        }
        /// <summary>
        /// Gets the salary and returns it.
        /// </summary>
        public double Salary { get; set; }
    }
}
