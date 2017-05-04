using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Multiplication operator class
    /// </summary>
    public class Multiplication : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Multiplication()
        {
            this.Precedence = Precedences.MultDiv;
        }

        /// <summary>
        /// Execute multiplication operator and push answer onto operands stack
        /// </summary>
        /// <param name="operands">stack of operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                // a * b
                Operand a = operands.Pop();
                Operand b = operands.Pop();
                Operand c = new Operand(a.Value * b.Value);
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
