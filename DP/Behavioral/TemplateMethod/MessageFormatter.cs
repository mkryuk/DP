using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.TemplateMethod
{
    public abstract class MessageFormatter
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }


        /// <summary>
        /// method that should be 
        /// overridden in the derived classes  
        /// </summary>
        protected abstract string Format();

        /// <summary>
        /// Checks message correcness
        /// </summary>
        protected abstract bool AllOk();

        /// Template method
        public string GetResult()
        {
            return AllOk() ? Format() : "Incorrect message.";
        }
    }
}
