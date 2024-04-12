namespace day4ConsoleApp;

class Program
{
    Employee CreateEmployeeArray(int id)
    {
        Employee employee = new Employee(id);
        Console.WriteLine("Enter Name");
        employee.Name = Console.ReadLine();
        Console.WriteLine("Enter Salary");
        employee.Salary = Convert.ToInt32(Console.ReadLine());
        return employee;    
    }
    static void Main(string[] args)
    {
        /// <summary>
        /// Default constructor demonstration of object creation
        /// </summary>

        Employee employee = new Employee();
        employee.Name = "Mridu";
        employee.Salary = 10000;
        employee.DateOfBirth = new DateTime(2000, 12, 18);
        employee.Email = "mridu@gmail.com";


       

        Employee[] employees = new Employee[3];
        Program program = new Program();
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = program.CreateEmployeeArray(100 + i);
        }
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].PrintEmployeeDetails();
        }

    }
    

}