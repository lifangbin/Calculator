using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Operands
{
    /// <summary>
    /// Divison operator
    /// </summary>
    public class Div : Operator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Div()
        {
            this.Precedence = Precedences.MultDiv;
        }

        /// <summary>
        /// Execute divison operator and put result into operands stack
        /// </summary>
        /// <param name="operands">stack with operands</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true/false if execution went well</returns>
        public override bool Execute(Stack<Operand> operands, CalculatorMode mode)
        {
            try
            {
                // b / a
                Operand a = operands.Pop();
                Operand b = operands.Pop();
                Operand c; // result

                // if we are in programming mode and both operands are integers
                // do a integer division
                if (mode == CalculatorMode.Programming &&
                    a.Value == (Int32)a.Value &&
                    b.Value == (Int32)b.Value)
                {
                    c = new Operand((Int32)b.Value / (Int32)a.Value);
                }
                else
                {
                    c = new Operand(b.Value / a.Value);
                }
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
