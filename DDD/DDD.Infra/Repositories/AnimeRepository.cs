using DDD.Domain.Command.Anime;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Domain.Query;
using DDD.Infra.Database;

namespace DDD.Infra.Repositories;

public class AnimeRepository(CustomDbContext context) 
    : IHandler<Anime, 
        AnimeQuery, 
        AnimeInsertCommand, 
        AnimeUpdateCommand, 
        AnimePatchCommand, 
        AnimeDeleteCommand>
{
    public Task<IEnumerable<Anime>> GetAsync(AnimeQuery query, CancellationToken cancellationToken = default)
    {

        throw new NotImplementedException();
    }

    public Task<IEnumerable<Anime>> InsertAsync(AnimeInsertCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Anime> UpdateAsync(AnimeUpdateCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Anime> PatchAsync(AnimePatchCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Anime> DeleteAsync(AnimeDeleteCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
