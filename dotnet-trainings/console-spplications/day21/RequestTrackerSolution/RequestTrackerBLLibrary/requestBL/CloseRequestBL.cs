using RequestTrackerDALLibrary;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.requestBL
{
    public class CloseRequestBL
    {
        private readonly UpdateRequestStatusRepository _repository;
        public CloseRequestBL()
        {
            UpdateRequestStatusRepository repo = new UpdateRequestStatusRepository(new RequestTrackerContext());
            _repository = repo;
        }
        public async Task<Request> CloseRequest(int request)
        {
            //var result = await _repository.Get(request);
            var updated = await _repository.UpdateStatus(request, "Closed");
            return updated;
        }
    }
}
