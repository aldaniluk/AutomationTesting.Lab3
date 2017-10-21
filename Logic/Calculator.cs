using System;

namespace Logic
{
    public static class Calculator
    {
        public static double Add(double lhs, double rhs) => lhs + rhs;

        public static double Substract(double lhs, double rhs) => lhs - rhs;

        public static double Multiply(double lhs, double rhs) => lhs * rhs;

        public static double Divide(double lhs, double rhs)
        {
            if (rhs == 0)
                throw new InvalidOperationException("Dividing by zero is not possible!");
            return lhs / rhs;
        }

    }
}
