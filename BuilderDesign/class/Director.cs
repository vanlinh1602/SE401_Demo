public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildMinimalNoodles()
    {
        this._builder.AddNoodles();
        this._builder.AddMeat();
        this._builder.AddSauce();
    }

    public void BuildFullNoodles()
    {
        this._builder.AddNoodles();
        this._builder.AddMeat();
        this._builder.AddShrimp();
        this._builder.AddVegetables();
        this._builder.AddSauce();
    }
}
