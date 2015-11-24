using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.GSM.Request
{
    public class AT_CFUNRequest : ATCommandBase
    {
        public string Fun { get; set; }
        public string Rst { get; set; }

        public AT_CFUNRequest() : base(CommandFormats.AT_CFUN)
        {
        }

        public override string ExecuteCommandString
        {
            get
            {
                return string.Concat(BaseCommandString, "=", Fun, string.IsNullOrWhiteSpace(Rst) ? "" : "," + Rst);
            }
        }
    }
}
