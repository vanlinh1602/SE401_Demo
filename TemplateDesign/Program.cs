public class Program
{
    public static void Main()
    {
        IWorker worker = new Manager();
        worker.DailyRoutine();
    }
}