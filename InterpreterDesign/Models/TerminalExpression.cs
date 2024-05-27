class BrandExpression : Expression
{
    public void InterpretContext(Context context)
    {
        if (context.getIsAircraft() == true)
        {
            if (context.getFirstChar().Equals("A"))
                Console.WriteLine("Brand is Airbus");
            else if (context.getFirstChar().Equals("B"))
                Console.WriteLine("Brand is Boeing");
        }
        else
            Console.WriteLine("Brand could not be interpreted");
    }
}

class ModelExpression : Expression
{
    public void InterpretContext(Context context)
    {
        if (context.getIsAircraft() == true)
        {
            Console.WriteLine("Model is : " + context.getModel().Substring(1, 3));
        }
        else
            Console.WriteLine("Model could not be interpreted");
    }
}

class TypeExpression : Expression
{
    public void InterpretContext(Context context)
    {
        if (context.getIsAircraft() == true)
        {
            string ac_model = context.getModel();
            if (context.getLenght() == 5 && context.getLastChar().Equals("F"))//F-> Freighter
            {
                Console.WriteLine("Aircraft type is Cargo/Freighter");
            }
            else
                Console.WriteLine("Aircraft type is Passenger Transportation");
        }
        else
            Console.WriteLine("Type could not be interpreted");
    }
}
