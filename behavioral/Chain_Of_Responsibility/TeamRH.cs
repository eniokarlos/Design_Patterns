namespace Chain_of_responsibility;

public sealed class TeamRH : Authorizer
{
    public TeamRH()
    {
        this.DAYS_CAN_BE_CONSENT = 30;
    }

    public override void AuthorizeLicense(string name, int days)
    {
        if(days <= DAYS_CAN_BE_CONSENT)
        {
            ApproveLicense(name, days);
        }
        else
        {
            Console.WriteLine($"License of {days} days to {name} cannot be approved");
        }
        
    }
    protected override void ApproveLicense(string name, int days)
    {
        Console.WriteLine($"The RH approved {days} of paid lisense " +
        $"to: {name}");
    }
}