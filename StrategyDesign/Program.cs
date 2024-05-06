public class TransportContext
{
    private IStrategy strategy;

    public TransportContext(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void moveToAirport()
    {
        strategy.move();
    }
}

public class Program
{
    public static void Main()
    {
        TransportContext context = new TransportContext(new PersonalCar());
        context.moveToAirport();
        context.SetStrategy(new Taxi());
        context.moveToAirport();
        context.SetStrategy(new Bus());
        context.moveToAirport();
    }
}