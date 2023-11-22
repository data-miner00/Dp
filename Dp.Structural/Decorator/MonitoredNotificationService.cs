namespace Dp.Structural.Decorator
{
    using Sentry;

    internal class MonitoredNotificationService : INotificationService
    {
        private readonly INotificationService notificationService;
        private readonly ISentryClient sentryClient;

        public MonitoredNotificationService(INotificationService notificationService, ISentryClient sentryClient)
        {
            this.notificationService = notificationService;
            this.sentryClient = sentryClient;
        }

        public async Task SendEmailAsync(string email)
        {
            await this.notificationService.SendEmailAsync(email).ConfigureAwait(false);

            this.sentryClient.CaptureEvent(new SentryEvent { Environment = "Dev", Message = "Send email called and success." });
        }
    }
}
