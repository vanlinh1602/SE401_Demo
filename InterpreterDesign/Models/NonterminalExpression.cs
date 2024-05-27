class CheckExpression : Expression
{
    public void InterpretContext(Context context)
    {
        //We assume tthe aircraft models only start with A or B and contains 4 or 5 chars.
        string ac_model = context.getModel();
        if (ac_model.StartsWith("A") || ac_model.StartsWith("B"))
        {
            if (ac_model.Length == 4 || ac_model.Length == 5)
            {
                context.setIsAircraft(true);
                Console.WriteLine(ac_model + " is an aircraft...");
            }
            else
            {
                context.setIsAircraft(false);
                Console.WriteLine(ac_model + " is not aircraft...");
            }
        }
        else
        {
            context.setIsAircraft(false);
            Console.WriteLine(ac_model + " is not aircraft...");
        }
    }
}
