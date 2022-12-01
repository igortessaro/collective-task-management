namespace CollectiveTasksManagement.Domain.Commands;

public sealed class CreateTargetGoalsCommand
{
    public string Name { get; set; } = string.Empty;
    public DateTime BeginDate { get; set; }
    public DateTime DeadLine { get; set; }
}
