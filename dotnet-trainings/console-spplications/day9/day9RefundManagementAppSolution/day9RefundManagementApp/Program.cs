using RefundMngtBLLibrary;
using RefundMngtModelLibrary;
using System.Diagnostics.Metrics;

namespace day9RefundManagementApp
{
    internal class Program
    {
        EmployeeBL employeeBL = new EmployeeBL();
        RefundRequestBL refundrequestBL = new RefundRequestBL();
        AcceptanceBL acceptanceBL = new AcceptanceBL();
        ExpenseType expenseRefund;
        Employee employee;
        Return reason;
        void AddEmployee()
        {
            
            try
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter dob");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                employee = new Employee() { Name = name, DateOfBirth=dob, Salary=salary };
                int id = employeeBL.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        void PrintEmployee()
        {
            Console.WriteLine("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee emp = employeeBL.GetEmployeeById(id);
            Console.WriteLine("Employee Name: \t" + emp.Name);
            Console.WriteLine("Employee Age: \t" + emp.Age);
            Console.WriteLine("Employee Salary: \t" + emp.Salary);
        }
        public string ChooseExpense()
        {
            string type;
            Console.WriteLine("Choose Expense Type: ");
            Console.WriteLine("1. Travel");
            Console.WriteLine("2. Meals");
            Console.WriteLine("3. Accommodation");
            Console.WriteLine("0. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Exiting");
                    return null;
                    break;
                case 1:
                    return type = "Travel";
                    break;
                case 2:
                    return type = "Meals";
                    break;
                case 3:
                    return type = "Accomodation";
                    break;
                    
            }
            throw new Exception("Invalid Choice");
        }

        void RaiseRequest()
        {
            try
            {
                int counter = 0;
                //do
                //{
                    string type = ChooseExpense();


                    Console.WriteLine("Enter date of issue");
                    DateTime doi = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter amount to be reimbursed");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Description");
                    string description = Console.ReadLine();

                    if (type == "Travel" )
                    {
                        expenseRefund = new Travel(type, doi, description, amount, employee);
                    }
                    else if (type == "Meals" )
                    {
                        expenseRefund = new Meals(type, doi, description, amount, employee);
                    }
                    else if (type == "Accomodation")
                    {
                        expenseRefund = new Accomodation(type, doi, description, amount, employee);
                    }
                    else
                    {
                        throw new Exception("Invalid entry");
                    }
                    int id = refundrequestBL.RaiseRequest(expenseRefund);
                    counter++;
                //}while (counter <4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        void Acceptance()
        {
            
            //Console.WriteLine(expenseRefund.ExpenseId);
           
            Console.WriteLine("Enter id for acceptance");
            int accId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choose Accept or Reject: ");
                Console.WriteLine("1. Accept");
                Console.WriteLine("2. Reject");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting");
                        
                        break;
                    case 1:
                        Console.WriteLine("Successfully accepted"); 
                        break;
                    case 2:
                    Console.WriteLine("Enter reason for rejection");
                    string msg = Console.ReadLine();
                    reason = new Return()
                    {
                        Reason = msg
                    };
                    Console.WriteLine("Rejected proposal for expense refund");
                    acceptanceBL.Rejected(accId);

                    break;
                }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddEmployee();
            program.PrintEmployee();
            program.RaiseRequest();
            program.Acceptance();
        }
    }
}
