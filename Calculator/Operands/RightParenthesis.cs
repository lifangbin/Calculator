using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Right parenthesis class
    /// </summary>
    public class RightParenthesis : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RightParenthesis()
        {
            this.Precedence = null;
        }

        /// <summary>
        /// Execute right parenthesis operator
        /// </summary>
        /// <param name="operands">stack with operands</param>
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
