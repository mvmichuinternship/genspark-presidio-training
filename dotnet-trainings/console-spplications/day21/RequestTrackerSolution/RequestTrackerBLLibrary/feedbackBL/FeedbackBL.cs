using RequestTrackerDALLibrary;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.feedbackBL
{
    public class FeedbackBL : IFeedbackBL
    {
        private readonly IRepository<int, Feedback> _repository;
        public FeedbackBL()
        {
            IRepository<int, Feedback> repo = new FeedbackRepository(new RequestTrackerContext());
            _repository = repo;
        }
        public async Task<Feedback> GiveFeedback(Feedback feedback)
        {
            var result = await _repository.Add(feedback);
            return result;
        }

        public async Task<Feedback> ViewFeedbackById(int feedback)
        {
            var result = await _repository.Get(feedback);
            return result;
        }
    }
}
