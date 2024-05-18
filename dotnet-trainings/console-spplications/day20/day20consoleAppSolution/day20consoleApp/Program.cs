using day20consoleApp.Model;

namespace day20consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeTrackerContext context = new EmployeeTrackerContext();
            //Area area = new Area();
            //area.Area1 = "POPO";
            //area.Zipcode = "44332";
            //context.Areas.Add(area);
            //context.SaveChanges();

            
            var areas = context.Areas.ToList();
            
            var area = areas.SingleOrDefault(a => a.Area1 == "TTTT");
            area.Zipcode = "00000";
            context.Areas.Update(area);
            context.SaveChanges();

            area = areas.SingleOrDefault(a => a.Area1 == "HYHY");
            context.Areas.Remove(area);
            context.SaveChanges();

            foreach (var area in areas)
            {
                Console.WriteLine(area.Area1 + " " + area.Zipcode);
            }
        }
    }
}

    

    //Scaffold-DbContext "Data Source= DESKTOP - DPV93JG\\SQLEXPRESS; Integrated Security = true; Initial Catalog = dbEmployeeTracker" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model