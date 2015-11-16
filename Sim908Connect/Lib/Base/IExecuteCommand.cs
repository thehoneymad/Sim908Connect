using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.Base
{
    public interface IExecuteCommand : ICommandType
    {
        string ExecuteCommandString { get; }
    }
}
