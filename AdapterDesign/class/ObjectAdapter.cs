
// Adapter class
public class ObjectAdapter : ITarget
{
    private readonly Adaptee _adaptee;

    public ObjectAdapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}

// Client
public class ClientObjectAdapter
{
    public void ExecuteRequest(ITarget target)
    {
        target.Request();
    }
}

