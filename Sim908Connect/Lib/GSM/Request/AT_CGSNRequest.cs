using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.Constants;
using Sim908Connect.Lib.GSM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.GSM.Request
{
    public class AT_CGSNRequest : ATCommandBase, ITestCommand
    {    
        public AT_CGSNRequest() : base(CommandFormats.AT_CGSNBASE)
        {

        }

        public override AT_CGSNTestResponse Test()
        {
            var command = this.TestCommandString;
            return new AT_CGSNTestResponse() {             
                Status = "OK"
            };
        }
        
    }
}
