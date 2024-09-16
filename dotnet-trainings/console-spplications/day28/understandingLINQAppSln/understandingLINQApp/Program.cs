using understandingLINQApp.Model;

namespace understandingLINQApp
{
    internal class Program
    {
         void PrintTheBooksPulisherwise()
        {
            pubsContext context = new pubsContext();
            var books = context.Titles
                        .GroupBy(t => t.PubId, t => t.Pub, (pid, title)=>new {Key=pid,TitleCount=title.Count() });
                        
            foreach ( var book in books )
            {
                Console.Write(book.Key);
                Console.WriteLine(" - "+book.TitleCount);
            }
        }
        void PrintNumberOfBooksFromType(string type)
          {
              pubsContext context = new pubsContext();
              var bookCount = context.Titles.Where(t=>t.Type == type).Count();
              Console.WriteLine($"There are {bookCount} in the type {type}");
          }
        void PrintAuthorNames()
        {
            pubsContext context = new pubsContext();
            var authors = context.Authors.ToList();
            foreach ( var author in authors )
            {
                Console.WriteLine(author.AuFname+" "+author.AuLname);
            }
        }

        void PrintTitleIdQuantityOrderId()
        {
            pubsContext context = new pubsContext();
            //var sales = context.Sales
            //        .GroupBy(s => s.TitleId)
            //        .Select(s => new
            //        {
            //            Id = s.Key,
            //            OrderDetails = s.Select(s => new
            //            {
            //                OrderId = s.OrdNum,
            //                Quantity = s.Qty
            //            })
            //        });
            //foreach (var order in sales)
            //{
            //    Console.WriteLine("Title is");
            //    Console.WriteLine(order.Id);

            //    Console.WriteLine("Order details are ");
            //    foreach (var item in order.OrderDetails)
            //    {
            //        Console.WriteLine(item.OrderId);
            //        Console.WriteLine(item.Quantity);
            //    }
            //}
            var sales = context.Sales.GroupBy(s => s.TitleId, s => s, (titleId, sales) => new {
                TitleId = titleId,
                Sales = sales.ToList()
            })
   .ToList();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.PrintAuthorNames();
            program.PrintTitleIdQuantityOrderId();
        }
    }
}
