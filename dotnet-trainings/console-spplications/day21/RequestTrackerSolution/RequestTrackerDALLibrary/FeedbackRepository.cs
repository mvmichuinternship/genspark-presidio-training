using Microsoft.EntityFrameworkCore;
using RequestTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerDALLibrary
{
    public class FeedbackRepository : IRepository<int, Feedback>
    {
        private readonly RequestTrackerContext _context;

        public FeedbackRepository(RequestTrackerContext context)
        {
            _context = context;
        }
        public async Task<Feedback> Add(Feedback entity)
        {
            _context.Feedbacks.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Feedback> Delete(int key)
        {
            var feedback = await Get(key);
            if (feedback != null)
            {
                _context.Feedbacks.Remove(feedback);
                await _context.SaveChangesAsync();
            }
            return feedback;
        }

        public async Task<Feedback> Get(int key)
        {
            var feedback = _context.Feedbacks.SingleOrDefault(e => e.FId == key);
            return feedback;
        }

        public async Task<IList<Feedback>> GetAll()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        public async Task<Feedback> Update(Feedback entity)
        {
            var feedback = await Get(entity.FId);
            if (feedback != null)
            {
                _context.Entry<Feedback>(feedback).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            return feedback;
        }
    }
}
