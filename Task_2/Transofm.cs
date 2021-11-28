using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertingNumber
{
    public class Transform
    {
        const int leftLimit = 2;
        const int rigthLimit = 20;       
        static char[] letters = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F','G','H','I','J'};
        private static char[] ConvertIntToChar(List<int> list, int basis)
        {              
            char[] resultArray = new char[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                 resultArray[i]= letters[list[i]];                
            }            
            return resultArray;
        }      
        public static string TransitionToNewNumberSystem(string[] args)
        {
            
            if (args.Length != 2)
            {
                throw new Exception("There must be exactly two arguments passed: number and radix");
            }   
            
            int value = 0;
            int radix = 0;

            if (!Int32.TryParse(args[0], out value) || !Int32.TryParse(args[1], out radix))
            {
                throw new Exception("Cannot convert to int. Correct the entered data");
            }
            if (radix < leftLimit || radix > rigthLimit)
            {
                throw new Exception("Incorrect input of the base of the new number system. " +
                    "Select a base from " + leftLimit + " to " + rigthLimit);
            }
            var list = new List<int>();
            do
            {
                list.Add(value % radix);
                value /= radix;
            }
            while (value != 0);
            char[] resultArray = ConvertIntToChar(list, radix);
            Array.Reverse(resultArray);
            string resultstr = new string(resultArray);
            return resultstr;
        }
    }
}