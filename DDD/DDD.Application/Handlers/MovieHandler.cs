using DDD.Application.Validators;
using DDD.Domain.Command.Movie;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Domain.Query;
using FluentValidation;

namespace DDD.Application.Handlers;

public class MovieHandler(
    IRepository<Movie, MovieQuery, MovieInsertCommand, MovieUpdateCommand, MoviePatchCommand, MovieDeleteCommand> repository,
    IValidator<MovieQuery> queryValidator, IValidator<MovieInsertCommand> insertValidator,
    IValidator<MovieUpdateCommand> updateValidator, IValidator<MoviePatchCommand> patchValidator,
    IValidator<MovieDeleteCommand> deleteValidator)
        : IHandler<Movie, MovieQuery, MovieInsertCommand, MovieUpdateCommand, MoviePatchCommand, MovieDeleteCommand>
{
    public async Task<IEnumerable<Movie>> GetAsync(MovieQuery query, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(query, queryValidator, cancellationToken);

        return await repository.GetAsync(query, cancellationToken);
    }

    public async Task<IEnumerable<Movie>> InsertAsync(MovieInsertCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, insertValidator, cancellationToken);

        return await repository.InsertAsync(command, cancellationToken);
    }

    public async Task<Movie> UpdateAsync(MovieUpdateCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, updateValidator, cancellationToken);

        return await repository.UpdateAsync(command, cancellationToken);
    }

    public async Task<Movie> PatchAsync(MoviePatchCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, patchValidator, cancellationToken);

        return await repository.PatchAsync(command, cancellationToken);
    }

    public async Task<Movie> DeleteAsync(MovieDeleteCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, deleteValidator, cancellationToken);

        return await repository.DeleteAsync(command, cancellationToken);
    }
}
