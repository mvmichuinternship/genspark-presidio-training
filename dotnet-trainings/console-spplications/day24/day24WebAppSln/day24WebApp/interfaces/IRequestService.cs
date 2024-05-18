using day24WebApp.models;

namespace day24WebApp.interfaces
{
    public interface IRequestService
    {
        public Task<Request> RaiseRequest(Request request);
        //public Task<string> ViewRequestStatusById(int request);
        public Task<IEnumerable<Request>> ViewRequest();
        public Task<Request> ViewRequestById(int request);
        //public Task<IList<string>> ViewRequestStatus();
    }
}
