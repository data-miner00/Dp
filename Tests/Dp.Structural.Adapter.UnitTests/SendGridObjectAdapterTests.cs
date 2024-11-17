namespace Dp.Structural.Adapter.UnitTests;

using Moq;
using SendGrid;
using System.Threading.Tasks;
using Dp.Structural.Adapter;
using SendGrid.Helpers.Mail;
using FluentAssertions;

public sealed class SendGridObjectAdapterTests
{
    private readonly Mock<ISendGridClient> mockClient = new();
    private readonly SendGridObjectAdapter adapter;

    private SendGridMessage? actualMessage;

    public SendGridObjectAdapterTests()
    {
        this.adapter = new(this.mockClient.Object);
    }

    [Fact]
    public async Task SendEmailAsync_WhenInvoked_AbleToCallSuccessfully()
    {
        const string Email = "shaun.chong@tuta.io";
        var expectedMesssage = GetExpectedMessage(Email);

        this.mockClient
            .Setup(x => x.SendEmailAsync(It.IsAny<SendGridMessage>(), It.IsAny<CancellationToken>()))
            .Callback((SendGridMessage message, CancellationToken _) => this.actualMessage = message)
            .ReturnsAsync(It.IsAny<Response>());

        await this.adapter.SendEmailAsync(Email);

        this.mockClient
            .Verify(x => x.SendEmailAsync(It.IsAny<SendGridMessage>(), It.IsAny<CancellationToken>()), Times.Once());

        this.actualMessage.Should().NotBeNull();
        this.actualMessage.Should().BeEquivalentTo(expectedMesssage);
    }

    private static SendGridMessage GetExpectedMessage(string email)
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

        return message;
    }
}
