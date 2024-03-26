using Autofac;
using Entities;
using InvocationApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new DefaultModule());

        var container = builder.Build();
        var willBeIntercepted = container.Resolve<IEmployee>();

        var emp1 = new Employee()
        {
            Id = 1,
            FirstName = "Salih",
            LastName = "SELEK"
        };
        willBeIntercepted.Add(emp1.Id, emp1.FirstName, emp1.LastName);

        Console.ReadKey();
    }
}