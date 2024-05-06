public class Manager : IWorker
{
    public override void work()
    {
        Console.WriteLine("Managing workers...");
    }

    public override void relax()
    {
        Console.WriteLine("Relax with video game...");
    }
}