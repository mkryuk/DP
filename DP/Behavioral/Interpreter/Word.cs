using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Interpreter
{
    /// <summary>
    /// Terminal expression
    /// </summary>
    public class Word : Expression
    {
        public string Data { get; set; }
        public override string Interpret(Context context)
        {
            return context.Translate(Data);
        }
    }
}
