using ConsoleApp2.LINQ.Implementation;
using ConsoleApp2.LINQ.Interface;
using ConsoleApp2.MultiThreading.Implementation;
using ConsoleApp2.MultiThreading.Interface;

public class Program
{
    private static readonly INumberProcessor numberProcessor = new NumberProcessor();
    private static readonly IProduct productService = new ProductService();
    
    public static void Main(string[] args)
    {
        // Multi-threading

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            int localNumber = number; // Capture the current number for the thread
            Thread thread = new Thread(() => numberProcessor.ProcessNumber(localNumber));
            thread.Start();
        }

        Console.WriteLine();

        // LINQ

        double minimumPrice = 500.00;

        var expensiveProducts = productService.GetProductNamesAbovePrice(minimumPrice);

        Console.WriteLine("Products with price greater than or equal to " + minimumPrice + ":");
        foreach (var productName in expensiveProducts)
        {
            Console.WriteLine(productName);
        }
    }
}