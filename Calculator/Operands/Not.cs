using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Not operator class
    /// </summary>
    public class Not : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Not()
        {
            this.Precedence = Precedences.Bitwise;
        }

        /// <summary>
        /// Execute not operator and push answer onto operands stack
        /// </summary>
        /// <param name="operands">stack with operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                // ~a
                Operand a = operands.Pop();
                Operand b = new Operand(~(Int64)a.Value);
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
