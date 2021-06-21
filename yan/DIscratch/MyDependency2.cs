using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.DIscratch
{
    public class MyDependency2 : IMyDependency
    {
        private readonly ILogger<MyDependency2> _logger;

        public MyDependency2(ILogger<MyDependency2> logger)
        {
            _logger = logger;
        }

        public void SendEmail()
        {
            _logger.LogWarning("something");
        }
    }
}
