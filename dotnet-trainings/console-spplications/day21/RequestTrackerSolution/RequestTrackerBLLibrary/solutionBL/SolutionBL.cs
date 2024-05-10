using RequestTrackerDALLibrary;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary.solutionBL
{
    public class SolutionBL : ISolutionBL
    {
        private readonly IRepository<int, RequestSolution> _repository;
        public SolutionBL() 
        {
            IRepository<int, RequestSolution> repo = new RequestSolutionRepository(new RequestTrackerContext());
            _repository = repo;
        }
        public async Task<RequestSolution> GiveSolution(RequestSolution solution)
        {
            var result = await _repository.Add(solution);
            return result;
        }
        

        

        public async Task<IList<RequestSolution>> ViewAllSolutions()
        {
            IList<RequestSolution> requestList = new List<RequestSolution>();
            requestList = await _repository.GetAll();
            //foreach (var item in result)
            //{
            //    requestList.Add(item);
            //}
            return requestList;
        }

        public async Task<RequestSolution> ViewSolutionById(int key)
        {
            var result = await _repository.Get(key);
            return result;
        }
    }
}
