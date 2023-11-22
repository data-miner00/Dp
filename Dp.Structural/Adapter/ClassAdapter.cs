namespace Dp.Structural.Adapter
{
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System.Threading.Tasks;

    /// <summary>
    /// Class adapter uses inheritance for adaptation.
    /// </summary>
    public class ClassAdapter : SendGridClient, INotificationService
    {
        public ClassAdapter(SendGridClientOptions options) : base(options)
        {
        }

        public Task SendEmailAsync(string email)
        {
            return this.SendEmailAsync(new SendGridMessage());
        }
    }
}
