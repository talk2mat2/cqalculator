using Calculator.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;



namespace Calculator
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("working");
            var serviceProvider = new ServiceCollection()
             .AddSingleton<ICalculator, Calculator.Infrastructure.Calculator>()
             .AddSingleton<ICalculatorService, CalculatorApp.Application.Services.CalculatorService>()
             .BuildServiceProvider();
            var calculatorService = serviceProvider.GetService<ICalculatorService>();

            while (true)
            {
                Console.WriteLine("Enter numbers for addition  :");
                var input = Console.ReadLine();

                try
                {
                    var result = calculatorService.Add(input, out var formula);
                    Console.WriteLine($"Result is: {result}");
                    Console.WriteLine($"Formula is: {formula}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error is : {ex.Message}");
                }
            }
        }
    }
}