using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.Constants;
using Sim908Connect.Lib.GSM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.GSM.Request.AT_CGSN
{
    public class AT_CGSNRequest : ATCommandBase
    {    
        public AT_CGSNRequest() : base(CommandFormats.AT_CGSNBASE)
        {

        }       
    }
}
