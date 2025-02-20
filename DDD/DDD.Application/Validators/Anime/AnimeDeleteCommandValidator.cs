﻿using DDD.Domain.Command.Anime;
using DDD.Domain.Query;
using FluentValidation;

namespace DDD.Application.Validators.Anime;

public class AnimeDeleteCommandValidator : AbstractValidator<AnimeDeleteCommand>
{

}
