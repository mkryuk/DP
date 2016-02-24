using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Interpreter
{
    public class UsingInterpreter
    {
        public static void Run()
        {
            var context = new EnRuContext();

            var sentence = new Sentence() {Expressions =
            {
                new Word {Data = "this"},
                new Word {Data = "is"},
                new Word {Data = "a"},
                new Word {Data = "simple"},
                new Word {Data = "sentence"}
            }};

            Console.WriteLine(sentence.Interpret(context));
        }
    }
}
