// Khởi tạo interface coffee
public interface ICoffee
{
    double Cost();
}
// Tạo lớp cà phê cơ bản
public class SimpleCoffee : ICoffee
{
    public double Cost()
    {
        return 10;
    }
}

// Tạo lớp decorator cho coffee
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public abstract double Cost();
}
// Thêm sữa cho coffee
public class Milk : CoffeeDecorator
{
    public Milk(ICoffee coffee) : base(coffee) { }

    public override double Cost()
    {
        // tính giá coffee thêm 5k
        return _coffee.Cost() + 5;
    }
}
// Thêm kem cho coffee
public class Whip : CoffeeDecorator
{
    public Whip(ICoffee coffee) : base(coffee) { }

    public override double Cost()
    {
        // tính giá coffee thêm 2k
        return _coffee.Cost() + 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Cà phê bình thường
        ICoffee myCoffee = new SimpleCoffee();
        Console.WriteLine("Simple coffee cost: $" + myCoffee.Cost());

        // Cà phê sữa
        myCoffee = new Milk(myCoffee);
        Console.WriteLine("Milk coffee: $" + myCoffee.Cost());

        // Cà phê kem sữa
        myCoffee = new Whip(myCoffee);
        Console.WriteLine("Whip Milk coffee: $" + myCoffee.Cost());
    }
}
