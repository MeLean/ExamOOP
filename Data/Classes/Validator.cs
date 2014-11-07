using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data.Classes
{
    internal  static class Validator
    {
        internal static int IntPropertyValidator (string property, int value, int MinValue, int MaxValue)
        {
            if (value >= MinValue && value <= MaxValue)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(string.Format("{0} must be in range {1} and {2}",
                    property, MinValue, MaxValue));
            }
        }

        internal static double DoublePropertyValidator(string property, double value, int MinValue, int MaxValue)
        {
            if (value >= MinValue && value <= MaxValue)
            {
                return value;
            }
            else
            {
                throw new ArgumentException(string.Format("{0} Rooms must be in range {1} and {2}",
                    property, MinValue, MaxValue));
            }
        }

        internal static decimal MoneyValueValidator(decimal money) 
        {
            if (money >= 0)
            {
                return money;
            }
            else
            {
                throw new AccessViolationException("Invalid valuer, price must be positive.");
            }
        }

        internal static string BooleanToString(bool value) 
        {
            string result = string.Empty;
            if (value)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }

            return result;
        }
    }
}
