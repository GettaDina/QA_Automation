using System;
using System.Collections.Generic;

namespace ConvertingNumber
{
    class Program
    {              
        static void Main(string[] args)
        {            
            try
            {
                Console.WriteLine(Transform.TransitionToNewNumberSystem(args));                              
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }                                     
        }        
    }
}
