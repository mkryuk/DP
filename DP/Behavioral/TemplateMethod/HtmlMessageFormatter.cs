using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.TemplateMethod
{
    public class HtmlMessageFormatter : MessageFormatter
    {      
        protected override string Format()
        {
            return $"<h1>From: {From}</h1>" +
                   $"<h1>To: {To}</h1>" +
                   $"<h3>Title: {Title}</h3>" +
                   $"<p>{Message}<p>";
        }

        /// <summary>
        /// Set required fields
        /// From To and Message are required
        /// </summary>
        protected override bool AllOk()
        {
            return From != null && To != null && Message != null;
        }
    }
}
