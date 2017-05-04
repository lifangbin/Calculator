using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Minus operator class
    /// </summary>
    public class Negative : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Negative()
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
                    // 0 - a
                    Operand a = operands.Pop();
                    Operand b = new Operand(0 - a.Value);
                    operands.Push(b);
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
