namespace BackgroundServiceExample.Interfaces
{
    public interface IBackgroundProcessWorkServiceFactory
    {
        IBackgroundProcessWorkService Resolve(IServiceProvider serviceProvider);
    }
}
