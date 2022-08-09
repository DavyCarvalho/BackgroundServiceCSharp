using System.Collections.Concurrent;
using BackgroundServiceExample.Interfaces;
using BackgroundServiceExample.Models;

namespace BackgroundServiceExample.Services
{
    public class QueuedBackgroundProcessService : BackgroundService, IQueuedBackgroundProcessService
    {
        private static readonly ConcurrentQueue<Guid> _queueProcessIds = new();
        private static readonly SemaphoreSlim _semaphoreSlim = new(0);

        private readonly IBackgroundProcessWorkServiceFactory _backgroundProcessWorkServiceFactory;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ILogger<QueuedBackgroundProcessService> _logger;

        public QueuedBackgroundProcessService(
            IBackgroundProcessWorkServiceFactory backgroundProcessWorkServiceFactory, 
            IServiceScopeFactory serviceScopeFactory, 
            ILogger<QueuedBackgroundProcessService> logger)
        {
            _backgroundProcessWorkServiceFactory = backgroundProcessWorkServiceFactory;
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

        public Task<Guid> StartNewAsync(BackgroundProcessStartNewModel backgroundProcessStartNew)
        {
            throw new NotImplementedException();
        }
    }
}
