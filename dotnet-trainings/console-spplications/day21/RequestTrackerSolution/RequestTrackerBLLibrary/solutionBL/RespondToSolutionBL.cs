using RequestTrackerDALLibrary;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.requestBL
{
    public class RespondToSolutionBL
    {
        private readonly UpdateSolutionComment _repository;
        public RespondToSolutionBL()
        {
            UpdateSolutionComment repo = new UpdateSolutionComment(new RequestTrackerContext());
            _repository = repo;
        }
        public async Task<RequestSolution> UpdateComment(int request, string comment)
        {
            //var result = await _repository.Get(request);
            var updated = await _repository.UpdateComment(request, comment);
            return updated;
        }
    }
}
