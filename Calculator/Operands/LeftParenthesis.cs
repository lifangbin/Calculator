using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Left parenthesis operand
    /// </summary>
    public class LeftParenthesis : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LeftParenthesis()
        {
            this.Precedence = null;
        }
        /// <summary>
        /// Execute left parenthesis operand (do nothing)
        /// </summary>
        /// <param name="operands">stack of operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well (always true)</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
