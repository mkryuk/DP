using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Behavioral.Chain_of_responsibility
{
    abstract class Handler
    {
        protected Handler NextHandler;
        protected Resource Result { get; } = new Resource();
        public virtual void AddNext(Handler handler)
        {
            NextHandler = handler;
        }    

        public virtual Resource GetResult()
        {
            return Result;
        }

        public abstract void Handle(Resource resource);
    }
}
