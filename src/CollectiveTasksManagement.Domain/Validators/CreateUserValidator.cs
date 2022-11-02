using CollectiveTasksManagement.Domain.Commands;
using FluentValidation;

namespace CollectiveTasksManagement.Domain.Validators;

public sealed class CreateUserValidator: AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.Email).EmailAddress();
        RuleFor(x => x.BirthDate).NotEmpty();
    }
}
