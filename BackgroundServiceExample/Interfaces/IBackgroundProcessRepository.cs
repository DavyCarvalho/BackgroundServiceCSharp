using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Interfaces
{
    public interface IBackgroundProcessRepository
    {
        Task<BackgroundProcess> GetTrackedById(Guid id);

        Task Add(BackgroundProcess backgroundProcess);

        Task<BackgroundProcess> GetById(Guid id);
    }
}
