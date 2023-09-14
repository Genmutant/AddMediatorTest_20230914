using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddMediator();
Console.WriteLine("After AddMediator!");