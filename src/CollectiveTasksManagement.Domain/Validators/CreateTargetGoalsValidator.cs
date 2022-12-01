using CollectiveTasksManagement.Domain.Commands;
using FluentValidation;

namespace CollectiveTasksManagement.Domain.Validators;

public sealed class CreateTargetGoalsValidator : AbstractValidator<CreateTargetGoalsCommand>
{
    public CreateTargetGoalsValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.BeginDate).GreaterThanOrEqualTo(DateTime.UtcNow);
        RuleFor(x => x.DeadLine).GreaterThan(x => x.BeginDate);
    }
}