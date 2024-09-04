using ConsoleApp2.MultiThreading.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.MultiThreading.Implementation
{
    public class NumberProcessor : INumberProcessor
    {
        // Multi-threading
        public void ProcessNumber(int number)
        {
            // Simulate a time-consuming operation
            Random random = new();
            int sleepTime = random.Next(1000, 5000); // Random sleep time between 1 and 5 seconds
            Thread.Sleep(sleepTime);
            Console.WriteLine($"Processed number {number} after sleeping for {sleepTime / 1000.0} seconds.");
        }
    }
}
