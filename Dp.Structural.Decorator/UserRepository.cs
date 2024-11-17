namespace Dp.Structural.Decorator;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

internal sealed class UserRepository : IRepository
{
    private readonly List<string> users = [];

    public Task AddAsync(string username, CancellationToken cancellationToken)
    {
        this.users.Add(username);

        return Task.CompletedTask;
    }

    public Task<IEnumerable<string>> GetAllAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(this.users.AsEnumerable());
    }
}
