
// Adaptee class

// Class Adapter class
public class ClassAdapter : Adaptee, ITarget
{
    public void Request()
    {
        SpecificRequest();
    }
}

// ClientClassAdapter
public class ClientClassAdapter
{
    private ITarget _target;

    public ClientClassAdapter(ITarget target)
    {
        _target = target;
    }

    public void MakeRequest()
    {
        _target.Request();
    }
}
