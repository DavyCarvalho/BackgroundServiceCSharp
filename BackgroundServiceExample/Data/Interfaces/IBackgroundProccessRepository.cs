using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Data.Interfaces
{
    public interface IBackgroundProccessRepository
    {
        void RegisterBackgroundProcess(BackgroundProccess backgroundProccess);
    }
}
