namespace Chain_of_responsibility;

public abstract class Authorizer
{
    protected int DAYS_CAN_BE_CONSENT;
    protected Authorizer? _authorizer;

    public void NextAuthorizer(Authorizer authorizer)
    {
        _authorizer = authorizer;
    }

    public virtual void AuthorizeLicense(string name, int days)
    {
        if(days <= DAYS_CAN_BE_CONSENT)
        {
            ApproveLicense(name, days);
        }
        else
        {
            _authorizer?.AuthorizeLicense(name, days);
        }
        
    }

    protected abstract void ApproveLicense(string name, int days);
}