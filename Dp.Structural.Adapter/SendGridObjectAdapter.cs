namespace Dp.Structural.Adapter;

using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

internal sealed class SendGridObjectAdapter : INotificationService
{
    private readonly ISendGridClient client;

    /// <summary>
    /// Initializes a new instance of the <see cref="SendGridObjectAdapter"/> class.
    /// </summary>
    /// <param name="client">The SendGrid client.</param>
    public SendGridObjectAdapter(ISendGridClient client)
    {
        this.client = client;
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

        return this.client.SendEmailAsync(message);
    }
}
