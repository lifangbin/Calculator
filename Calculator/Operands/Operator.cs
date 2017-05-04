using System.Collections.Generic;

namespace Calculator.Operands
{
    /// <summary>
    /// Precedences (the higher the precedence is the sooner it gets executed)
    /// </summary>
    public enum Precedences
    {
        /// <summary>
        /// Plus and minus precedence factor
        /// </summary>
        PlusMinus = 1,
        /// <summary>
        /// Multiplication and division precedence factor
        /// </summary>
        MultDiv = 2,
        /// <summary>
        /// Bitwise (e.g. and, xor) precedence factor
        /// </summary>
        Bitwise = 3,
        /// <summary>
        /// Exponential calculations precedence factor
        /// </summary>
        Exponent = 4,
        /// <summary>
        /// Function calculations precedence factor
        /// </summary>
        Function = 5,
        /// <summary>
        /// Gaussian Function precedence factor
        /// </summary>
        Gaussian = 6,
    }

    /// <summary>
    /// Abstract operator class
    /// </summary>
    public abstract class Operator : Op
    {
        /// <summary>
        /// Precedence of operator
        /// </summary>
        public Precedences? Precedence { get; protected set; }

        /// <summary>
        /// Execute operator
        /// </summary>
        /// <param name="operands">stack of operands to execute on</param>
        /// <param name="mode">mode to operate in</param>
        /// <returns>true / false if succeeded</returns>
        public abstract bool Execute(Stack<Operand> operands, CalculatorMode mode);
    }
}
