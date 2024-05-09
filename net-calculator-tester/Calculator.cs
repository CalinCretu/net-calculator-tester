using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public float Add(float x, float y)
        {
            return x + y;
        }

        public float Subtract(float x, float y)
        {
            return x - y;
        }

        public float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new System.ArgumentException("Cannot divide by zero.");
            }
            return x / y;
        }

        public float Multiply(float x, float y)
        {
            return x * y;
        }
    }
}