namespace CollectiveTasksManagement.Domain.Entities;

public sealed class TargetGoals
{
    public string Name { get; set; } = string.Empty;
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime DeadLine { get; set; }
}