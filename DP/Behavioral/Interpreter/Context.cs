using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Interpreter
{
    /// <summary>
    /// Abstract context
    /// </summary>
    public abstract class Context
    {
        public abstract string Translate(string word);
    }
}
