using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Plus operator class
    /// </summary>
    public class Plus : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Plus()
        {
            this.Precedence = Precedences.PlusMinus;
        }

        /// <summary>
        /// Execute plus operator and push answer onto operands stack
        /// </summary>
        /// <param name="operands">stack with operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                Operand a = operands.Pop();
                Operand b = operands.Pop();
                Operand c = new Operand(a.Value + b.Value);
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
