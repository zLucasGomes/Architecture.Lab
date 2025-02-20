namespace DDD.Domain.Interfaces;

public interface ICrudCommand<Entity, Get, Post, Put, Patch, Delete>
{
    public Task<IEnumerable<Entity>> GetAsync(Get query, CancellationToken cancellationToken = default);

    public Task<IEnumerable<Entity>> InsertAsync(Post command, CancellationToken cancellationToken = default);

    public Task<Entity> UpdateAsync(Put command, CancellationToken cancellationToken = default);

    public Task<Entity> PatchAsync(Patch command, CancellationToken cancellationToken = default);

    public Task<Entity> DeleteAsync(Delete command, CancellationToken cancellationToken = default);
}

