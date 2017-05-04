using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// And (&) operator class
    /// </summary>
    public class And : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public And()
        {
            this.Precedence = Precedences.Bitwise;
        }

        /// <summary>
        /// Execute and operator and put answer into operands stack
        /// </summary>
        /// <param name="operands">stack of operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                // b & a
                Operand a = operands.Pop();
                Operand b = operands.Pop();
                Operand c = new Operand((Int64)b.Value & (Int64)a.Value);
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
