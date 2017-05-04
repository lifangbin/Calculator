using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Minus operator class
    /// </summary>
    public class Minus : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Minus()
        {
            this.Precedence = Precedences.PlusMinus;
        }

        /// <summary>
        /// Execute minus operator and push answer on operands stack
        /// </summary>
        /// <param name="operands">stack with operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                    // b - a
                    Operand a = operands.Pop();
                    Operand b = operands.Pop();
                    Operand c = new Operand(b.Value - a.Value);
                    operands.Push(c);
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
