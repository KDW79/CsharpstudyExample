using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_GenTest
{
    class Calculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da + db;
            return result;
        }

        public T Substract(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da - db;
            return result;
        }

        public T Muntiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da * db;
            return result;
        }

        public T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da / db;
            return result;
        }
    }

    class IntCalculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Substract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public int Muntiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }

    class DoubleCalculator
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Substract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Muntiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }
    }

    class DecimalCalculator
    {
        public decimal Add(decimal a, decimal b)
        {
            decimal result = a + b;
            return result;
        }

        public decimal Substract(decimal a, decimal b)
        {
            decimal result = a - b;
            return result;
        }

        public decimal Muntiply(decimal a, decimal b)
        {
            decimal result = a * b;
            return result;
        }

        public decimal Divide(decimal a, decimal b)
        {
            decimal result = a / b;
            return result;
        }
    }

    class LongCalculator { }

    class FloatCalculator { }


}
