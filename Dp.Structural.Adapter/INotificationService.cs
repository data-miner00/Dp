namespace Dp.Structural.Adapter;

using System.Threading.Tasks;

/// <summary>
/// An interface for notification service.
/// This is the "Targer" in the adapter pattern.
/// </summary>
internal interface INotificationService
{
    /// <summary>
    /// Sends a hello email to the specified email address.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <returns>The task.</returns>
    Task SendEmailAsync(string email);
}
