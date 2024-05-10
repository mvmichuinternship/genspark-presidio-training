using RequestTrackerBLLibrary.feedbackBL;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerFEAPP
{
    public class FeedBackPrograms
    {
        IFeedbackBL feedbackBL = new FeedbackBL();
        public async Task<Feedback> GiveFeedbacks(string fbdesc, DateTime date, int eid, float ratings, int sid)
        {
            Feedback feedback = new Feedback() {  FeedBack= fbdesc, FeedbackDate= date, EmployeeId=eid, IsHelpful=true, Ratings = ratings, SolId = sid};
            var result = await feedbackBL.GiveFeedback(feedback);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot give feedback");
            }
        }

        public async Task GetFeedbackDetails()
        {
            await Console.Out.WriteLineAsync("Please enter Solution Id");
            int sid = Convert.ToInt32(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter feedback");
            string fbdesc = Console.ReadLine() ?? "";
            await Console.Out.WriteLineAsync("Please enter Rating");
            float ratings = Convert.ToSingle(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter Feedback Date");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter Employee Id");
            int eid = Convert.ToInt32(Console.ReadLine());
            var res = await GiveFeedbacks(fbdesc, date, eid, ratings, sid );
            await Console.Out.WriteLineAsync(res.FeedBack);
        }


        public async Task<Feedback> ViewFeedbacks(int id)
        {
            var result = await feedbackBL.ViewFeedbackById(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot give feedback");
            }
        }

        public async Task GetFeedbackByIdDetails()
        {
            await Console.Out.WriteLineAsync("Please enter Solution Id");
            int fid = Convert.ToInt32(Console.ReadLine());
            var res = await ViewFeedbacks(fid);
            await Console.Out.WriteLineAsync(res.FeedBack);
        }
    }
}
