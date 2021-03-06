using System;
using System.Collections.Generic;
namespace Calculator
{
    /// <summary>
    /// Constants
    /// </summary>
    public class Constants
    {
        public Dictionary<string, double?>ConstantDict;
        /// <summary>
        /// Constructor, initialize constant class with relevant constants.
        /// </summary>
        public Constants()
        {
            this.ConstantDict = new Dictionary<string, double?>();

            // Mathematical constants
            this.ConstantDict.Add("pi", 3.141592653589793); // Pi
            this.ConstantDict.Add("e", 2.718281828);        // Natural Logarithm
            this.ConstantDict.Add("phi", 1.61803398874);    // The Golden Ratio

            // Programming constants
            this.ConstantDict.Add("s32max", Int32.MaxValue);   // 32 bit integer max
            this.ConstantDict.Add("s32min", Int32.MinValue);   // 32 bit integer min
            this.ConstantDict.Add("u32max", UInt32.MaxValue);  // 32 bit unsigned integer max
            this.ConstantDict.Add("u32min", UInt32.MinValue);  // 32 bit unsigned integer min
            this.ConstantDict.Add("s16max", Int16.MaxValue);   // 16 bit integer max
            this.ConstantDict.Add("s16min", Int16.MinValue);   // 16 bit integer min
            this.ConstantDict.Add("u16max", UInt16.MaxValue);  // 16 bit unsigned integer max
            this.ConstantDict.Add("u16min", UInt16.MinValue);  // 16 bit unsigned integer min
            this.ConstantDict.Add("s8max", 127);               // 8 bit integer max
            this.ConstantDict.Add("s8min", -127);              // 8 bit integer min
            this.ConstantDict.Add("u8max", 255);               // 8 bit unsigned integer max
            this.ConstantDict.Add("u8min", 0);                 // 8 bit unsigned integer min
        }
        /// <summary>
        /// checks if a string is declared in the the dictionary of constants
        /// and in that case retreives the parameter
        /// </summary>
        /// <param name="Key">Key string to check</param>
        /// <param name="RetVal">storage for constant if found</param>
        /// <returns>True if constant was found, else False</returns>
        public bool TryGetValue(string Key, out double? RetVal)
        {
            return this.ConstantDict.TryGetValue(Key.ToLower(), out RetVal);
        }
    }
}

