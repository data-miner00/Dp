namespace Dp.Structural.Decorator;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;

public class KeyPrefixedCache : IDistributedCache
{
    private readonly IDistributedCache cache;
    private readonly string prefix;

    private string PrefixKey(string key) => $"{this.prefix}_{key}";

    public KeyPrefixedCache(IDistributedCache cache, string prefix)
    {
        this.cache = cache;
        this.prefix = prefix;
    }

    public byte[]? Get(string key) => this.cache.Get(this.PrefixKey(key));

    public Task<byte[]?> GetAsync(string key, CancellationToken token = default) =>
        this.cache.GetAsync(this.PrefixKey(key), token);

    public void Refresh(string key) =>
        this.cache.Refresh(this.PrefixKey(key));

    public Task RefreshAsync(string key, CancellationToken token = default) =>
        this.cache.RefreshAsync(this.PrefixKey(key), token);

    public void Remove(string key) =>
        this.cache.Remove(this.PrefixKey(key));

    public Task RemoveAsync(string key, CancellationToken token = default) =>
        this.cache.RemoveAsync(this.PrefixKey(key), token);

    public void Set(string key, byte[] value, DistributedCacheEntryOptions options) =>
        this.cache.Set(this.PrefixKey(key), value, options);

    public Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, CancellationToken token = default) =>
        this.cache.SetAsync(this.PrefixKey(key), value, options, token);
}