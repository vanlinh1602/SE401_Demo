public interface IBuilder
{
    void AddMeat();

    void AddShrimp();

    void AddNoodles();

    void AddSauce();

    void AddVegetables();
}
public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public ConcreteBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._product = new Product();
    }

    public void AddMeat()
    {
        this._product.Add("Meat");
    }

    public void AddShrimp()
    {
        this._product.Add("Shrimp");
    }

    public void AddNoodles()
    {
        this._product.Add("Noodles");
    }

    public void AddSauce()
    {
        this._product.Add("Sauce");
    }

    public void AddVegetables()
    {
        this._product.Add("Vegetables");
    }

    public Product GetProduct()
    {
        Product result = this._product;

        this.Reset();

        return result;
    }
}

