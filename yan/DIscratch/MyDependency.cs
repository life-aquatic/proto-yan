using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.DIscratch
{
    public class MyDependency : IMyDependency
    {
        public void SendEmail()
        {
            string impl = "Let's imagine we have some kind of an implementation";
        }
    }
}
