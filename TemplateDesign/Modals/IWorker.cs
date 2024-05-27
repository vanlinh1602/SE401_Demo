public abstract class IWorker
{
    public void DailyRoutine()
    {
        getUp();
        eatBreakfast();
        goToWork();
        work();
        goHome();
        relax();
        sleep();
    }

    public virtual void getUp()
    {
        Console.WriteLine("Getting up...");
    }
    public virtual void eatBreakfast()
    {
        Console.WriteLine("Eating breakfast...");
    }
    public virtual void goToWork()
    {
        Console.WriteLine("Going to work...");
    }
    public virtual void work()
    {
        Console.WriteLine("Working...");
    }
    public virtual void goHome()
    {
        Console.WriteLine("Going home...");
    }
    public virtual void sleep()
    {
        Console.WriteLine("Sleeping...");
    }
    public virtual void relax()
    {
        Console.WriteLine("Relaxing...");
    }

}