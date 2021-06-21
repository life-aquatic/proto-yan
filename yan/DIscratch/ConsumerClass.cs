using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.DIscratch
{
    public class ConsumerClass
    {
        private readonly IEnumerable<IMyDependency> _myDependencies;

        public ConsumerClass(IEnumerable<IMyDependency> myDependencies)
        {
            _myDependencies = myDependencies;
        }

        public void Consume()
        {
            foreach (var i in _myDependencies)
            {
                i.SendEmail();
            }
        }
    }
}
