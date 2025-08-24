using Microsoft.Extensions.Hosting;
using Presentation;

namespace JohnDeere.Services
{
    public class JDBackgroundService : IHostedService
    {
        private IPresentation _presentation;
        public JDBackgroundService(IPresentation presentation)
        {
            _presentation = presentation;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("JDBackgroundService is starting...");

            // Start the presentation logic
            var infoForComments = await _presentation.GetComments();

            Console.WriteLine(infoForComments);

            Console.WriteLine("JDBackgroundService has finished.");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
