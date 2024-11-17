namespace Dp.Structural.Decorator;

using System.Threading.Tasks;

internal interface IRepository
{
    /// <summary>
    /// Adds a user to database.
    /// </summary>
    /// <param name="username">The username.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The task.</returns>
    Task AddAsync(string username, CancellationToken cancellationToken);

    /// <summary>
    /// Gets all the user in the database.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The task.</returns>
    Task<IEnumerable<string>> GetAllAsync(CancellationToken cancellationToken);
}
