using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.GSM.Request;
using Sim908Connect.Lib.GSM.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.GSM.Processor
{
    public class AT_CFUNRequestProcessor : IProcessorFor<AT_CFUNRequest>
    {

        CommandExecutor _executor;

        public AT_CFUNRequestProcessor(CommandExecutor executor)
        {
            if (executor == null)
                throw new ArgumentNullException("Executor cant be null");

            _executor = executor;
        }
        public ATCommandResponseBase Process(AT_CFUNRequest request)
        {
           switch(request.ATCommandMode)
            {
                case (ATCommandModes.EXECUTE):
                    return ProcessExecute(request);
                case (ATCommandModes.TEST):
                case ATCommandModes.READ:
                    throw new NotImplementedException("Processing for this mode has not been implemented yet");
                default:
                    throw new InvalidOperationException(string.Concat("Specified ATCommand Mode ", request.ATCommandMode, " is not available for ", request.BaseCommandString));

            }
        }

        private AT_CFUNExecuteResponse ProcessExecute(AT_CFUNRequest request)
        {
            if (string.IsNullOrEmpty(request.Fun))
                throw new Exception("AT+CFUN Fun parameter null or zero");

            var data = _executor.Execute(request.ExecuteCommandString);
            throw new NotImplementedException("Not Implemented yet");

        }
    }
}
