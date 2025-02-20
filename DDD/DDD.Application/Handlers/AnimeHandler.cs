using DDD.Application.Validators;
using DDD.Domain.Command.Anime;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Domain.Query;
using FluentValidation;

namespace DDD.Application.Handlers;

public class AnimeHandler(
    IRepository<Anime, AnimeQuery, AnimeInsertCommand, AnimeUpdateCommand, AnimePatchCommand, AnimeDeleteCommand> repository,
    IValidator<AnimeQuery> queryValidator, IValidator<AnimeInsertCommand> insertValidator,
    IValidator<AnimeUpdateCommand> updateValidator, IValidator<AnimePatchCommand> patchValidator,
    IValidator<AnimeDeleteCommand> deleteValidator)
        : IHandler<Anime, AnimeQuery, AnimeInsertCommand, AnimeUpdateCommand, AnimePatchCommand, AnimeDeleteCommand>
{
    public async Task<IEnumerable<Anime>> GetAsync(AnimeQuery query, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(query, queryValidator, cancellationToken);

        return await repository.GetAsync(query, cancellationToken);
    }

    public async Task<IEnumerable<Anime>> InsertAsync(AnimeInsertCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, insertValidator, cancellationToken);

        return await repository.InsertAsync(command, cancellationToken);
    }

    public async Task<Anime> UpdateAsync(AnimeUpdateCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, updateValidator, cancellationToken);

        return await repository.UpdateAsync(command, cancellationToken);
    }

    public async Task<Anime> PatchAsync(AnimePatchCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, patchValidator, cancellationToken);

        return await repository.PatchAsync(command, cancellationToken);
    }

    public async Task<Anime> DeleteAsync(AnimeDeleteCommand command, CancellationToken cancellationToken = default)
    {
        await Validator.ValidateAsync(command, deleteValidator, cancellationToken);

        return await repository.DeleteAsync(command, cancellationToken);
    }
}
