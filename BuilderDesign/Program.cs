using System.Text;

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Tô mì 20k:");
director.BuildMinimalNoodles();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Tô mì 30k:");
director.BuildFullNoodles();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Tô mì tuỳ chọn:");
builder.AddNoodles();
builder.AddSauce();
builder.AddShrimp();
Console.Write(builder.GetProduct().ListParts());