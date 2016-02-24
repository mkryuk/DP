using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Interpreter
{
    /// <summary>
    /// Nonterminal expression
    /// </summary>
    public class Sentence : Expression
    {
        public List<Expression> Expressions { get; set; } = new List<Expression>();
       
        public override string Interpret(Context context)
        {
            var data = new StringBuilder();
            Expressions.ForEach(expression => data.Append(expression.Interpret(context) + " "));
            return data.ToString();
        }
    }
}
