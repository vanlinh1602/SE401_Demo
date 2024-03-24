public abstract class GiftBase
{
    protected string name;
    protected int price;

    public GiftBase(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public abstract int CalculateTotalPrice();
}
public interface IGiftOperations
{
    void Add(GiftBase gift);
    void Remove(GiftBase gift);
}
