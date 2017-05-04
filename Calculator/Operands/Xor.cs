using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Xor operator class
    /// </summary>
    public class Xor : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Xor()
        {
            this.Precedence = Precedences.Bitwise;
        }

        /// <summary>
        /// Execute xor operator and push answer onto operands stack
        /// </summary>
        /// <param name="operands">stack with operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                // b ^ a
                Operand a = operands.Pop();
                Operand b = operands.Pop();
                Operand c = new Operand((Int64)b.Value ^ (Int64)a.Value);
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
