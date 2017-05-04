using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Modulus operator class
    /// </summary>
    public class Modulus : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Modulus()
        {
            this.Precedence = Precedences.MultDiv;
        }

        /// <summary>
        /// Execute modules operator and push answer onto operands stack
        /// </summary>
        /// <param name="operands">stac with operandsk</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                // b % a
                Operand a = operands.Pop();
                Operand b = operands.Pop();
                Operand c = new Operand(b.Value % a.Value);
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
