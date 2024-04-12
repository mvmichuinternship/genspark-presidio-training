internal class Program
{
    class Employee
    {
        double salary;

        public string Name { get; set; }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return (salary - (salary * 10 / 100));
            }
        }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        
    }
}