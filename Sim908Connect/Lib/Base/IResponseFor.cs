using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.Base
{
    public interface IResponseFor<TRequest, in TRequestType> 
        where TRequest : ATCommandBase
        where TRequestType : ICommandType
    {

    }
}
