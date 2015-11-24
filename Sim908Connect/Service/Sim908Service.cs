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
        public TResponse Process<TRequest, TResponse, TProcessor>(TRequest request, TProcessor processor)
            where TRequest : ATCommandBase
            where TResponse : class, IResponseFor<TRequest>
            where TProcessor : class, IProcessorFor<TRequest>
        {
            return processor.Process(request) as TResponse;
        }
    }
}
