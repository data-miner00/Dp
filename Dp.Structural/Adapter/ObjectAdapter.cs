using SendGrid;
using SendGrid.Helpers.Mail;

namespace Dp.Structural.Adapter
{
    /// <summary>
    /// Object adapter uses composition for adaptation.
    /// </summary>
    internal class ObjectAdapter : INotificationService
    {
        private readonly SendGridClient client;

        public ObjectAdapter(SendGridClient client)
        {
            this.client = client;
        }

        public Task SendEmailAsync(string email)
        {
            return this.client.SendEmailAsync(new SendGridMessage());
        }
    }
}
