namespace Dp.Structural.Decorator
{
    internal interface INotificationService
    {
        Task SendEmailAsync(string email);
    }
}
