using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace ASP3.Services
{
    public class CalcService
    {
        public float Plus(float a, float b)
        {
            return a + b;
        }

        public float Minus(float a, float b)
        {
            return a - b;
        }

        public float Mult(float a, float b)
        {
            return a * b;
        }

        public float Divide(float a, float b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Divide by zero error");
            }

            return a / b;
        }

        public float Max(float a, float b)
        {
            return a >= b ? a : b;
        }

        public float Min(float a, float b)
        {
            return a <= b ? a : b;
        }
    }
}
