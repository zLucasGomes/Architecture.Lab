using FluentValidation;
using FluentValidation.Results;

namespace DDD.Application.Validators;

public static class Validator
{
    public static async Task ValidateAsync<T>(T request, IValidator<T> validator, CancellationToken cancellationToken = default)
    {
        ValidationResult result = await validator.ValidateAsync(request, cancellationToken);

        if (!result.IsValid)
            throw new Exception(result.Errors[0].ErrorMessage);
    }
}
