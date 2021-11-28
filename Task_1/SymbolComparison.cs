using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class SymbolComparison     
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int MaxNumberOfNonRepearingSymbol(string[] args)
        {           
            if (args.Length != 1)
            {
                throw new Exception("The line is missing or there are several lines");
            }
            string str = args[0];
            int counter = 1;
            int maxValueCurrentIteration = 1;
            bool comparisonResult = true;          
            for (int i = 1, k = 0; i < str.Length; i++)
            {
                for (int j = k; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        comparisonResult = false;
                    }
                }
                if (comparisonResult)
                {
                    maxValueCurrentIteration++;
                }
                else
                {
                    comparisonResult = true;
                    k = i;
                    if (maxValueCurrentIteration > counter)
                    {
                        counter = maxValueCurrentIteration;
                    }
                    maxValueCurrentIteration = 1;
                }
            }
            if (maxValueCurrentIteration > counter)
            {
                counter = maxValueCurrentIteration;
            }
            return counter;
        }
    }
}
