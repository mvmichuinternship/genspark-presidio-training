using day24WebApp.contexts;
using day24WebApp.interfaces;
using day24WebApp.models;
using day24WebApp.repositories;

namespace day24WebApp.services
{
    public class RequestService: IRequestService
    {
        private readonly IRepository<int, Request> _repository;
        public RequestService(IRepository<int, Request> repo)
        {
            _repository = repo;
        }
        public async Task<Request> RaiseRequest(Request request)
        {
            var result = await _repository.Add(request);
            return result;
        }

        public async Task<Request> ViewRequestById(int request)
        {
            var result = await _repository.Get(request);
            return result;
        }

        public async Task<IEnumerable<Request>> ViewRequest()
        {
            var result = await _repository.Get();
            return result;
        }

        //public async Task<string> ViewRequestStatusById(int request)
        //{
        //    var result = await _repository.Get(request);
        //    return result.RequestStatus;
        //}

        //public async Task<IEnumerable<string>> ViewRequestStatus()
        //{
        //    //IEnumerable<string> requestList = new List<string>();
        //    var result = await _repository.Get();

        //    return result;
        //}
    }
}
