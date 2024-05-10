using RequestTrackerBLLibrary.requestBL;
using RequestTrackerBLLibrary.solutionBL;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerFEAPP
{
    public class SolutionProvider
    {
        ISolutionBL solutionBL = new SolutionBL();
        async Task<RequestSolution> ProvideSolution(int id, string name, string desc, DateTime date, int eid)
        {
            RequestSolution requestSolution = new RequestSolution() { RequestId = id, SolName=name, SolDescription=desc, SolvedBy=eid, SolvedDate = date, IsSolved=true};
            var result = await solutionBL.GiveSolution(requestSolution);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot send solution");
            }
        }

        public async Task GetDeatilsForGiveSolution()
        {
            await Console.Out.WriteLineAsync("Please enter Request Id");
            int id = Convert.ToInt32(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter solution name");
            string name = Console.ReadLine() ?? "";
            await Console.Out.WriteLineAsync("Please enter solution description");
            string desc = Console.ReadLine() ?? "";
            await Console.Out.WriteLineAsync("Please enter Solution Date");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter Employee Id");
            int eid = Convert.ToInt32(Console.ReadLine());
            var res = await ProvideSolution(id, name, desc, date, eid);
            await Console.Out.WriteLineAsync(res.SolName);
        }

        async Task<RequestSolution> ResponseToSolution(int id, string comment)
        {
            RespondToSolutionBL respondToSolution = new RespondToSolutionBL();
            var result = await respondToSolution.UpdateComment(id, comment);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot send comment");
            }
        }

        public async Task GetDeatilsForComments()
        {
            await Console.Out.WriteLineAsync("Please enter Solution Id");
            int id = Convert.ToInt32(Console.ReadLine());
            await Console.Out.WriteLineAsync("Please enter Comment");
            string comment = Console.ReadLine() ?? "";
            var res = await ResponseToSolution(id, comment);
            await Console.Out.WriteLineAsync(res.RequestRaiserComment);
        }


        async Task<RequestSolution> ViewSolutionId(int id)
        {
            var result = await solutionBL.ViewSolutionById(id);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot send solution");
            }
        }

        public async Task GetIdForViewSolution()
        {
            await Console.Out.WriteLineAsync("Please enter Request Id");
            int id = Convert.ToInt32(Console.ReadLine());
            var res = await ViewSolutionId(id);
            await Console.Out.WriteLineAsync(res.SolName);
        }


        async Task<IList<RequestSolution>> ViewSolutions()
        {
            var result = await solutionBL.ViewAllSolutions();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception("Cannot send solution");
            }
        }

        public async Task GetListViewSolution()
        {
            await Console.Out.WriteLineAsync("View all solutions");
            var res = await ViewSolutions();
            await Console.Out.WriteLineAsync(res[0].SolName);
        }
    }
}
