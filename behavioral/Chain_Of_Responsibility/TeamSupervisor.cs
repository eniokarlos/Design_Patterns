namespace Chain_of_responsibility;

public sealed  class TeamSupervisor : Authorizer
{
    public TeamSupervisor()
    {
        this.DAYS_CAN_BE_CONSENT = 15;
    }

    protected override void ApproveLicense(string name, int days)
    {
        Console.WriteLine($"The Team Supervisor approved {days} of paid lisense " +
        $"to: {name}");
    }
}