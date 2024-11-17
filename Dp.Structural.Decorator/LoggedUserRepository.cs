namespace Dp.Structural.Decorator;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

internal sealed class LoggedUserRepository : IRepository
{
    private readonly IRepository repository;
    private readonly List<string> logs = [];

    public LoggedUserRepository(IRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<string> Logs => this.logs;

    /// <inheritdoc/>
    public Task AddAsync(string username, CancellationToken cancellationToken)
    {
        this.logs.Add($"[{DateTime.Now}]: Add called with username '{username}'.");
        return this.repository.AddAsync(username, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<IEnumerable<string>> GetAllAsync(CancellationToken cancellationToken)
    {
        this.logs.Add($"[{DateTime.Now}]: GetAll called.");
        return this.repository.GetAllAsync(cancellationToken);
    }
}
