using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Interfaces
{
    public interface IBackgroundProcessWorkService
    {
        Task DoWorkAsync(BackgroundProcess backgroundProcess);
    }
}
