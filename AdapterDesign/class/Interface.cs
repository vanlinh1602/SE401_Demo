public interface ITarget
{
    void Request();
}


public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's SpecificRequest method called");
    }
}