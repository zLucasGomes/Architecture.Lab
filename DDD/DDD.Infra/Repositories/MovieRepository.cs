using DDD.Domain.Command.Movie;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Domain.Query;
using DDD.Infra.Database;

namespace DDD.Infra.Repositories;

public class MovieRepository(CustomDbContext context) 
    : IHandler<Movie,
        MovieQuery,
        MovieInsertCommand,
        MovieUpdateCommand,
        MoviePatchCommand,
        MovieDeleteCommand>
{
    public Task<IEnumerable<Movie>> GetAsync(MovieQuery query, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Movie>> InsertAsync(MovieInsertCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> UpdateAsync(MovieUpdateCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> PatchAsync(MoviePatchCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> DeleteAsync(MovieDeleteCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
