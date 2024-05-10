using RequestTrackerBLLibrary.requestBL;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerFEAPP
{
    public class RequestRaise
    {
        async Task<Request> RaiseRequestProgram( string message, DateTime date, int eId)
        {
        Request request = new Request() { RequestMessage = message, RequestStatus= "open", RequestDate=date, RequestRaisedBy=eId, RequestClosedBy=101 };
        IRaiseRequestBL raiseRequestBL = new RaiseRequestBL();
            var result = await raiseRequestBL.RaiseRequest(request);
            if (result!=null)
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid data");
            }
        }
        public async Task GetRequestDeatils()
        {
            await Console.Out.WriteLineAsync("Please enter your request message");
            string message = Console.ReadLine() ?? "";
            await Console.Out.WriteLineAsync("Please enter Request Date");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter Employee Id");
            int eid = Convert.ToInt32(Console.ReadLine());
            await RaiseRequestProgram( message, date, eid);
        }


        async Task<Request> ViewRequestByIdProgram( int Id)
        {
            
            IRaiseRequestBL raiseRequestBL = new RaiseRequestBL();
            var result = await raiseRequestBL.ViewRequestById(Id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Request doesn't exist");
            }
        }
        public async Task GetIdForViewRequest()
        {
            await Console.Out.WriteLineAsync("Please enter Request Id");
            int id = Convert.ToInt32(Console.ReadLine());
            var res = await ViewRequestByIdProgram(id);
            await Console.Out.WriteLineAsync(res.RequestStatus);

        }

        async Task<string> ViewRequestStatusByIdProgram(int Id)
        {

            IRaiseRequestBL raiseRequestBL = new RaiseRequestBL();
            var result = await raiseRequestBL.ViewRequestStatusById(Id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Request doesn't exist");
            }
        }
        public async Task GetIdForViewRequestStatus()
        {
            await Console.Out.WriteLineAsync("Please enter Request Id");
            int id = Convert.ToInt32(Console.ReadLine());
            var res = await ViewRequestStatusByIdProgram(id);
            await Console.Out.WriteLineAsync(res);
        }


        async Task<IList<string>> ViewRequestStatusProgram()
        {

            IRaiseRequestBL raiseRequestBL = new RaiseRequestBL();
            var result = await raiseRequestBL.ViewRequestStatus();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Request doesn't exist");
            }
        }
        public async Task GetForViewRequestStatus()
        {
            await Console.Out.WriteLineAsync("ViewStatus");
            var res =await ViewRequestStatusProgram();
            await Console.Out.WriteLineAsync(res[0]);

        }


        public async Task<Request> CloseRequestProgram(int id)
        {
            CloseRequestBL raiseRequestBL = new CloseRequestBL();
            var result = await raiseRequestBL.CloseRequest(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Error closing request");
            }
        }
        public async Task GetIdForCloseRequest()
        {
            await Console.Out.WriteLineAsync("Please enter Request Id");
            int id = Convert.ToInt32(Console.ReadLine());
            var res = await CloseRequestProgram(id);
            await Console.Out.WriteLineAsync(res.RequestStatus);
        }
    }
}
