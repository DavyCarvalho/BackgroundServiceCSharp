using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Data.Interfaces
{
    public interface IBackgroundProccessRepository
    {
        Task<BackgroundProcess> GetTrackedById(Guid id);

        Task Add(BackgroundProcess backgroundProcess);

        Task<BackgroundProcess> GetById(Guid id);
    }
}
