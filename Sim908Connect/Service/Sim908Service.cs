using Sim908Connect.Lib.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Service
{
    public class Sim908Service
    {
        public TResponse Test<TRequest, TResponse>(TRequest request)
            where TRequest : ATCommandBase
            where TResponse : Lib.Base.IResponseFor<ATCommandBase, ITestCommand>
        {
            throw new NotImplementedException();
        }
    }
}
