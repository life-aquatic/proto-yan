using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.DIscratch
{
    public interface IOperation
    {
        public string Operation { get; }
    }

    public interface IOperationTransient : IOperation { }
    public interface IOperationScoped : IOperation { }
    public interface IOperationSigleton : IOperation { }
}
