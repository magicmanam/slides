using System;
using System.Collections.Generic;
using System.Text;

namespace samples
{
    class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    public interface ICalculator
    {
        // Query: always the same result with no side effect
        int Sum(int a, int b);
    }
}
