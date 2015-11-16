using Sim908Connect.Lib.GSM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.Base
{
    public abstract class ATCommandBase
    {
        public virtual string BaseCommandString { get; set; }
        public virtual string TestCommandString { get { return string.Concat(BaseCommandString, "=?"); } }
        public virtual string ExecuteCommandString { get { return BaseCommandString; } }

        public ATCommandBase(string baseCommandString)
        {
            this.BaseCommandString = BaseCommandString;
        }

        public abstract AT_CGSNTestResponse Test();


    }
}
