using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.requestBL
{
    public interface IRaiseRequestBL
    {
        public Task<Request> RaiseRequest(Request request);
        public Task<string> ViewRequestStatusById(int request);
        public Task<Request> ViewRequestById(int request);
        public Task<IList<string>> ViewRequestStatus();

    }
}
