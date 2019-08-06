using System;

namespace Sample1.Lib
{
    public class MathOperator : IMathOperator
    {
        public decimal Add(decimal first, decimal second)=>first+second;
        
        public decimal Divide(decimal first, decimal second)
        {
            try
            { 
                decimal result = first / second;
                return result;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }

        }
    }
}