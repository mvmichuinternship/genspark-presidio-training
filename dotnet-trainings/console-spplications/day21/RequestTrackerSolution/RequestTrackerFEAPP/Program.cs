using RequestTrackerBLLibrary.employeeBL;
using RequestTrackerModelLibrary;
using System.Threading.Channels;

namespace RequestTrackerFEAPP
{
    internal class Program
    {
        async Task<bool> EmployeeLoginAsync(int username, string password)
        {
            Employee employee = new Employee() { Password = password,Id=username };
            IEmployeeLoginBL employeeLoginBL = new EmployeeLoginBL();
            var result = await employeeLoginBL.Login(employee);
            if (result)
            {
                return true;
            }
            else
            {
                //Console.Out.WriteLine("Invalid username or password");
                return false;
            }
        }
        async Task<bool> GetLoginDeatils()
        {
            await Console.Out.WriteLineAsync("Please enter Employee Id");
            int id = Convert.ToInt32(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter your password");
            string password = Console.ReadLine() ?? "";
            var res = await EmployeeLoginAsync(id,password);
            return res;
        }

        void UserMenu()
        {
            Console.WriteLine("1. Raise request");
            Console.WriteLine("2. View request");
            Console.WriteLine("3. View request status");
            Console.WriteLine("4. Give comments");
            Console.WriteLine("3. View solution");
            Console.WriteLine("3. View feedback");
            Console.WriteLine("0. Exit");
        }

        async Task UserTasks()
        {
            RequestRaise requestRaise = new RequestRaise();
            SolutionProvider solutionProvider = new SolutionProvider();
            FeedBackPrograms fb = new FeedBackPrograms();
            var res = await GetLoginDeatils();
            if (res == true)
            {
                UserMenu();

                Console.WriteLine("Please select an option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.....");
                        break;
                    case 1:
                        await requestRaise.GetRequestDeatils();
                        break;
                    case 2:
                        await requestRaise.GetIdForViewRequest();
                        break;
                    case 3:
                        await requestRaise.GetIdForViewRequestStatus();
                        break;
                    case 4:
                        await solutionProvider.GetDeatilsForComments();
                        break;
                    case 5:
                        await solutionProvider.GetIdForViewSolution();
                        break;
                    case 6:
                        await fb.GetFeedbackByIdDetails();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;

                }
            }
        }

            void AdminMenu()
            {
                Console.WriteLine("1. Close request");
                Console.WriteLine("2. View request");
                Console.WriteLine("3. View request status");
                Console.WriteLine("4. View all request status");
                Console.WriteLine("4. Give solution");
                Console.WriteLine("4. View solution");
                Console.WriteLine("4. Give feedback");
                Console.WriteLine("4. View feedback");


            Console.WriteLine("0. Exit");
            }

            async Task AdminTasks()
            {
                RequestRaise requestRaise = new RequestRaise();
            SolutionProvider solutionProvider = new SolutionProvider();
            FeedBackPrograms fb = new FeedBackPrograms();
            var res = await GetLoginDeatils();
                if (res == true)
                {
                    AdminMenu();

                    Console.WriteLine("Please select an option");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Bye.....");
                            break;
                        case 1:
                            await requestRaise.GetIdForCloseRequest();
                            break;
                        case 2:
                            await requestRaise.GetIdForViewRequest();
                            break;
                        case 3:
                            await requestRaise.GetIdForViewRequestStatus();
                            break;
                        case 4:
                            await requestRaise.GetForViewRequestStatus();
                            break;
                        case 5:
                            await solutionProvider.GetDeatilsForGiveSolution();
                        break;
                        case 6:
                            await solutionProvider.GetListViewSolution();
                        break;
                        case 7:
                        await fb.GetFeedbackDetails();
                        break;
                        case 8:
                               await fb.GetFeedbackByIdDetails();
                        break;

                        default:
                            Console.WriteLine("Invalid choice. Try again");
                            break;

                    }
                }
            }

                static async Task Main(string[] args)
        {
            //await new Program().GetLoginDeatils();
            RequestRaise requestRaise = new RequestRaise();
            //await requestRaise.GetRequestDeatils();
            //await requestRaise.GetIdForViewRequestStatus();
            //await requestRaise.GetForViewRequestStatus();
            //await requestRaise.GetIdForCloseRequest();



            SolutionProvider solutionProvider = new SolutionProvider();
            //await solutionProvider.GetDeatilsForGiveSolution();
            //await solutionProvider.GetDeatilsForComments();
            //await solutionProvider.GetIdForViewSolution();
            //await solutionProvider.GetListViewSolution();



            FeedBackPrograms fb = new FeedBackPrograms();
            //await fb.GetFeedbackDetails();
            //await fb.GetFeedbackByIdDetails();

            Console.WriteLine("1. User");
            Console.WriteLine("2. Admin");
            Console.WriteLine("0. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Bye.....");
                    break;
                case 1:
                    await new Program().UserTasks();
                    break;
                case 2:
                    await new Program().AdminTasks();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            }
    }
}
