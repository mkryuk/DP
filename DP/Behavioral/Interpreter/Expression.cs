using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Interpreter
{
    /// <summary>
    /// Abstract expression
    /// </summary>
    public abstract class Expression
    {
        public abstract string Interpret(Context context);
    }
}
