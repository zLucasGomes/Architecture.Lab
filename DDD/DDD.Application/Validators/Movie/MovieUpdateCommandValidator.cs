﻿using DDD.Domain.Command.Movie;
using DDD.Domain.Query;
using FluentValidation;

namespace DDD.Application.Validators.Movie;

public class MovieUpdateCommandValidator : AbstractValidator<MovieUpdateCommand>
{

}
