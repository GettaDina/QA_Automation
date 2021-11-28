using System;
using System.Windows;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Maximum number of unequal consecutive symbols = "
                        + SymbolComparison.MaxNumberOfNonRepearingSymbol(args));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }      
    }
}
