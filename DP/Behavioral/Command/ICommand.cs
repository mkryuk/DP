using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Command
{
    /// <summary>
    /// Interface that descrbes command
    /// </summary>
    public interface ICommand
    {
        void Execute();        
        List<string> GetResult();
    }
}
