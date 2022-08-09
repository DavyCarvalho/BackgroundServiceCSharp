using BackgroundServiceExample.Data.Interfaces;
using BackgroundServiceExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BackgroundServiceExample.Data.Repositories
{
    public class BackgroundProccessRepository : IBackgroundProccessRepository
    {
        private readonly AppDbContext _context;

        public BackgroundProccessRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(BackgroundProcess backgroundProcess)
        {
            await _context.BackgroundProcesses.AddAsync(backgroundProcess);
        }

        public async Task<BackgroundProcess> GetById(Guid id)
        {
            return await _context.BackgroundProcesses.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<BackgroundProcess> GetTrackedById(Guid id)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            _context.ChangeTracker.AutoDetectChangesEnabled = true;

            return await GetById(id);
        }
    }
}
