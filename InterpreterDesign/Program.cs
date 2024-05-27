class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Interpreter Design Pattern Example - TheCodeprogram";

        List<Context> lstAircrafts = new List<Context>();
        List<Expression> lstExpressions = new List<Expression>();

        lstAircrafts.Add(new Context("A330"));
        lstAircrafts.Add(new Context("A330F"));
        lstAircrafts.Add(new Context("B777"));
        lstAircrafts.Add(new Context("B777F"));
        lstAircrafts.Add(new Context("TheCode"));

        lstExpressions.Add(new CheckExpression());
        lstExpressions.Add(new BrandExpression());
        lstExpressions.Add(new ModelExpression());
        lstExpressions.Add(new TypeExpression());

        for (int ac_index = 0; ac_index < lstAircrafts.Count; ac_index++)
        {
            for (int exp_index = 0; exp_index < lstExpressions.Count; exp_index++)
            {
                lstExpressions[exp_index].InterpretContext(lstAircrafts[ac_index]);
            }
            Console.WriteLine("-----------------------------------");
        }
        Console.ReadLine();
    }
}
