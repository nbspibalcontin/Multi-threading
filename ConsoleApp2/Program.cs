using ConsoleApp2.MultiThreading.Implementation;
using ConsoleApp2.MultiThreading.Interface;

public class Program
{
    private static readonly INumberProcessor numberProcessor = new NumberProcessor();
    
    public static void Main(string[] args)
    {
        try
        {
            // Multi-threading

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Thread thread = new Thread(() => numberProcessor.ProcessNumber(number));
                thread.Start();
            }
        }
        catch (Exception ex) 
        { 
            Console.WriteLine($"Error: ${ex.Message}");
        }
    }
}