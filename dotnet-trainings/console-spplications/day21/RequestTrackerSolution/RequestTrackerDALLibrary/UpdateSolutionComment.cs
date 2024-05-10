using Microsoft.EntityFrameworkCore;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerDALLibrary
{
    public class UpdateSolutionComment
    {
        private readonly RequestTrackerContext _context;

        public UpdateSolutionComment(RequestTrackerContext context)
        {
            _context = context;
        }


        public async Task<RequestSolution> UpdateComment(int id, string comment)
        {
            var result = await _context.RequestSolutions.FindAsync(id);
            if (result == null)
            {
                return null;
            }
            result.RequestRaiserComment = comment;
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
