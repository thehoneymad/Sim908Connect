using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.Profile.Request.ATE
{

    public class ATERequest : ATCommandBase
    {
        public enum ATERequestType
        {
            DISABLE,
            ENABLE
        }

        public ATERequestType Toggle { get; set; }

        public ATERequest() : base(CommandFormats.ATE)
        {
        }

        public override string ExecuteCommandString
        {
            get
            {
                return BaseCommandString + ((int)Toggle).ToString();
            }
        }
    }
}
