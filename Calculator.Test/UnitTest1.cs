using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExpressionEvaluate()
        {
            var expressions = new[]
            {
                "2+3-4",
                "-1+5-4",
                "2*3+4",
                "2*(3+5)",
                "2*(3+5)/6",
                "2*(2*(2*(2+1)))",
                "10%3",
                "1+16.5/(2+gauss(5,2,3,1))",
                "sqrt(6)",
                "abs(-7)",
                "floor(1.5)",
            };

            foreach (string expression in expressions)
            {
                Calculator cal = new Calculator(expression)
                {
                    Mode = CalculatorMode.Mathematics
                };

                Console.WriteLine("{0} = {1}", expression, cal.Calculate());
            }

        }

        [TestMethod]
        public void ShouldHaveErrorMessages()
        {
            var expressions = new[]
            {
                "(2+3+4",
                "1+5-4-",
                "2*(3+5)/0",
                "%3",
                "abc(123)",
                "1+16.5/(2+gauss(5,1,0,1))" // NaN means zero by zero
            };

            foreach (string expression in expressions)
            {
                Calculator cal = new Calculator(expression)
                {
                    Mode = CalculatorMode.Mathematics
                };

                try
                {
                    Console.WriteLine("{0} = {1}", expression, cal.Calculate());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} = {1}", expression, ex.Message);
                }
            }
        }
    }
}
