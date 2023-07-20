namespace Chain_of_responsibility;

public sealed class ProjectManager : Authorizer
{
    public ProjectManager()
    {
        this.DAYS_CAN_BE_CONSENT = 5;
    }
    protected override void ApproveLicense(string name, int days)
    {
        Console.WriteLine($"The project manager approved {days} of paid lisense " +
        $"to: {name}");
    }

}