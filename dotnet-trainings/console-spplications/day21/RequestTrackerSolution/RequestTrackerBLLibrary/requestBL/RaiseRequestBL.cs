using RequestTrackerDALLibrary;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.requestBL
{
    public class RaiseRequestBL : IRaiseRequestBL
    {
        private readonly IRepository<int, Request> _repository;
        public RaiseRequestBL()
        {
            IRepository<int, Request> repo = new RequestRepository(new RequestTrackerContext());
            _repository = repo;
        }
        public async Task<Request>  RaiseRequest(Request request)
        {
            var result = await _repository.Add(request);
            return result;
        }

        public async Task<Request> ViewRequestById(int request)
        {
            var result = await _repository.Get(request);
            return result;
        }

        public async Task<string> ViewRequestStatusById(int request)
        {
            var result = await _repository.Get(request);
            return result.RequestStatus;
        }

        public async Task<IList<string>> ViewRequestStatus()
        {
            IList<string> requestList = new List<string>();
            var result = await _repository.GetAll();
            foreach (var item in result)
            {
                requestList.Add(item.RequestStatus);
            }
            return requestList;
        }

        
    }
}
