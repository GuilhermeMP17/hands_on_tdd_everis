using System;
using Sample1.Lib;
using Xunit;

namespace Sample1.Test
{
    public class MathOperatorTest
    {
        [Fact]
        public void RetunrSumOfTwoNumbers()
        {
            //Given
            decimal first = 10;
            decimal second = 20;
            decimal expected = 30;
            
            decimal result;

            var mathOperator = new MathOperator();
            //When
            result = mathOperator.Add(first, second);
            //Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RetornaExeptionNaDivisaoPorZero()
        {
            //Given
            decimal first = 10;
            decimal second = 0;

            var mathOperator = new MathOperator();
            //When            
            //Then
            Assert.Throws<DivideByZeroException>(() => mathOperator.Divide(first, second));
        }

        [Fact]
        public void DeveDarErroAoTentarDividirPorDoisNumeros()
        {
            //Given
            var first = 100;
            var second = 2;
            var mathOperator = new MathOperator();
            decimal expected = 50;
            decimal result;          
            //When       
              result = mathOperator.Divide(first, second);     
            //Then
            Assert.Equal(expected, result);
        }
    }
}
