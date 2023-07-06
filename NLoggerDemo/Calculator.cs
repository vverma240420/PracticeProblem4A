using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLoggerDemo
{
    internal class Calculator
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public int CalculateSum(int a, int b)
        {
            logger.Info($"Calculating the sum of {a} and {b}.");
            int sum = a + b;
            logger.Info($"The sum of {a} and {b} is {sum}.");
            return sum;

        }
    }
}
