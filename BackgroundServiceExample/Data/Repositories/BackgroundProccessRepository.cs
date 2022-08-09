using BackgroundServiceExample.Data.Interfaces;
using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Data.Repositories
{
    public class BackgroundProccessRepository : IBackgroundProccessRepository
    {
        private readonly AppDbContext _context;

        public BackgroundProccessRepository(AppDbContext context)
        {
            _context = context;
        }

        public void RegisterBackgroundProcess(BackgroundProccess backgroundProccess)
        {
            _context.BackgroundProccesses.ToList();
        }
    }
}
