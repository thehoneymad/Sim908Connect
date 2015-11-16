using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.GSM.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.GSM.Response
{
    public class AT_CGSNTestResponse : IResponseFor<AT_CGSNRequest, ITestCommand>
    {
        public string Status { get; set; }

    }
}
