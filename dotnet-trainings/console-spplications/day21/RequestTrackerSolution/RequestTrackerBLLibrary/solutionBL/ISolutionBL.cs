using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.solutionBL
{
    public interface ISolutionBL
    {
        public Task<RequestSolution> ViewSolutionById(int key);
        public Task<RequestSolution> GiveSolution(RequestSolution solution);
        public Task<IList<RequestSolution>> ViewAllSolutions();
    }
}
