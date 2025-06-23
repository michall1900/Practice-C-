using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymFitnessManagement.Utilities
{
    public static class InputValidator 
    {
        public static void CheckIfPositiveNumber(double num)
        {
            if (Double.IsNegative(num))
            {
                throw new ArgumentException("The number is not positive.");
            }
        }

        public static void CheckIfIntInRange(int num, int min, int max)
        {
            if ((num < min) || (num > max)) 
            {
                throw new ArgumentException($"The number should between {min} and {max}.");
            }
        }

    
    }
}
