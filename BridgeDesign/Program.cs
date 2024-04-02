using System.Text;

// Tạo interface cho implementor (Payment)
public interface Payment
{
    void payWage(int money);
}

// Concrete Implementor CashPayment
public class CashPayment : Payment
{
    public void payWage(int money)
    {
        Console.WriteLine($"Trả lương bằng tiền mặt: {money}");
    }
}

// Concrete Implementor BankingPayment
public class BankingPayment : Payment
{
    public void payWage(int money)
    {
        Console.WriteLine($"Trả lương bằng chuyển khoản: {money}");
    }
}

// Tạo abstract cho abstraction (Staff)
public abstract class Staff
{
    protected Payment _payment;

    public Staff(Payment payment)
    {
        _payment = payment;
    }

    public abstract void payWage(int money);
}

// Concrete Abstraction ManagerStaff
public class ManagerStaff : Staff
{
    public ManagerStaff(Payment payment) : base(payment) { }

    public override void payWage(int money)
    {
        Console.WriteLine("Quản lý:");
        _payment.payWage(money);
    }
}

// Concrete Abstraction WaiterStaff
public class WaiterStaff : Staff
{
    public WaiterStaff(Payment payment) : base(payment) { }

    public override void payWage(int money)
    {
        Console.WriteLine("Phục vụ:");
        _payment.payWage(money);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Payment cashPayment = new CashPayment();
        Payment bankingPayment = new BankingPayment();

        // Tạo abstraction và gán implementor
        Staff manager = new ManagerStaff(bankingPayment);
        // Staff manager = new ManagerStaff(cashPayment);
        manager.payWage(10000);

        Staff waiter = new WaiterStaff(cashPayment);
        // Staff waiter = new WaiterStaff(bankingPayment);
        waiter.payWage(2000);
    }
}
