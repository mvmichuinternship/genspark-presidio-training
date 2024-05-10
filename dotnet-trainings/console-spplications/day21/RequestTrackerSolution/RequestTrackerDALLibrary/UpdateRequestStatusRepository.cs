using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerDALLibrary
{
    public class UpdateRequestStatusRepository
    {
        private readonly RequestTrackerContext _context;

        public UpdateRequestStatusRepository(RequestTrackerContext context)
        {
            _context = context;
        }

        //public async Task<Request> Get(int request)
        //{
        //    var result =  _context.Requests.SingleOrDefault(e => e.RequestNumber == request);
        //    return result;
        //}

        public async Task<Request> UpdateStatus(int id, string status)
        {
            var result = await _context.Requests.FindAsync(id);
            if (result == null) {
                return null;
            }
                result.RequestStatus = status;
                await _context.SaveChangesAsync();
                return result;
        }
    }
}
