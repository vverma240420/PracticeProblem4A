using NLog;

namespace NLoggerDemo
{
    internal class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
              logger.Info("Program Started");
              try
              {
                  Console.WriteLine("Enter the first number: ");
                  int num1= int.Parse(Console.ReadLine());

                  Console.WriteLine("Enter the second number: ");
                  int num2= int.Parse(Console.ReadLine());

                  Calculator c= new Calculator();
                  int sum= c.CalculateSum(num1, num2);
                  Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
              }
              catch (Exception ex) 
              {
                  logger.Error(ex, "Error Found");
                  Console.WriteLine("Error Found");
              }
              logger.Info("Program Finished");
              Console.ReadLine();  
        }
    }
}