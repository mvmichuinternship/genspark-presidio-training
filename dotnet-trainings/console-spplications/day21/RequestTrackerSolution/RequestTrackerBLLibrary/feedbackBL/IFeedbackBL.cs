using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.feedbackBL
{
    public interface IFeedbackBL
    {
        public Task<Feedback> GiveFeedback(Feedback feedback);
        public Task<Feedback> ViewFeedbackById(int feedback);
    }
}
