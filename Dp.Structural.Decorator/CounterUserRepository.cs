namespace Dp.Structural.Decorator;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

internal sealed class CounterUserRepository : IRepository
{
    private readonly IRepository repository;
    private int addCounter = 0;
    private int getAllCounter = 0;

    public CounterUserRepository(IRepository repository)
    {
        this.repository = repository;
    }

    /// <summary>
    /// Gets the total count of Add invocations.
    /// </summary>
    public int AddCounter => this.addCounter;

    /// <summary>
    /// Gets the total count of GetAll invocations.
    /// </summary>
    public int GetAllCounter => this.getAllCounter;

    /// <inheritdoc/>
    public Task AddAsync(string username, CancellationToken cancellationToken)
    {
        this.addCounter++;
        return this.repository.AddAsync(username, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<IEnumerable<string>> GetAllAsync(CancellationToken cancellationToken)
    {
        this.getAllCounter++;
        return this.repository.GetAllAsync(cancellationToken);
    }
}
