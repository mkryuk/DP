using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.TemplateMethod
{
    public class JsonMessageFormatter : MessageFormatter
    {     
        protected override string Format()
        {
            return $"{{ " + $"'from':'{From}', " +
                   $"'to':'{To}', " +
                   $"'title':'{Title}', " +
                   $"'message':'{Message}' }}";
        }

        /// <summary>
        /// Set required fields
        /// From and To are required
        /// </summary>
        protected override bool AllOk()
        {
            return From != null && To != null;
        }
    }
}
