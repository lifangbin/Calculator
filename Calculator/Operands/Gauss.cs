using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operands
{
    public class Gauss: Operator
    {
        public Gauss()
        {
            this.Precedence = Precedences.Gaussian;
        }

        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try {
                Operand o = operands.Pop();
                string[] g = o.Array.ToString().Split(',');
                double a = Convert.ToDouble(g[0]);
                double b = Convert.ToDouble(g[1]);
                double c = Convert.ToDouble(g[2]);
                double x = Convert.ToDouble(g[3]);

                double q = Math.Pow(x - b, 2);
                double w = Math.Pow(c, 2) * 2;
                double r = q / w;
                double e = 2.718281828; // Natural Logarithm

                double t = Math.Pow(e, r);

                Operand result = new Operand(a * (1 / t));

                operands.Push(result);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
