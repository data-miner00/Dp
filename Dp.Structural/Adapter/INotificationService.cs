namespace Dp.Structural.Adapter
{
    internal interface INotificationService
    {
        Task SendEmailAsync(string email);
    }
}
