using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Interfaces
{
    public interface IQueuedBackgroundProcessService
    {
        Task<Guid> StartNewAsync(BackgroundProcessStartNewModel backgroundProcessStartNew);
    }
}
