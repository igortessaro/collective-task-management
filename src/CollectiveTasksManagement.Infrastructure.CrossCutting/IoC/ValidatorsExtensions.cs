using CollectiveTasksManagement.Domain.Commands;
using CollectiveTasksManagement.Domain.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace CollectiveTasksManagement.Infrastructure.CrossCutting.IoC;

public static class ValidatorsExtensions
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        _ = services.AddFluentValidationAutoValidation();
        _ = services.AddScoped<IValidator<CreateUserCommand>, CreateUserValidator>();

        return services;
    }
}
