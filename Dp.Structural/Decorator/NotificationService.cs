namespace Dp.Structural.Decorator
{
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System.Threading.Tasks;

    internal class NotificationService : INotificationService
    {
        private readonly SendGridClient sendGridClient;

        public NotificationService(SendGridClient sendGridClient)
        {
            this.sendGridClient = sendGridClient;
        }

        public Task SendEmailAsync(string email)
        {
            return this.sendGridClient.SendEmailAsync(new SendGridMessage());
        }
    }
}
