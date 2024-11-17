namespace Dp.Structural.Adapter;

using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

internal sealed class SendGridClassAdapter : SendGridClient, INotificationService
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendGridClassAdapter"/> class.
    /// </summary>
    /// <param name="options">The SendGrid client options.</param>
    public SendGridClassAdapter(SendGridClientOptions options)
        : base(options)
    {
    }

    /// <inheritdoc/>
    public Task SendEmailAsync(string email)
    {
        var content = new Content
        {
            Type = "text/plain",
            Value = "hello",
        };

        var message = new SendGridMessage
        {
            Contents = [content],
        };

        message.AddTo(email);

        return this.SendEmailAsync(message);
    }
}
