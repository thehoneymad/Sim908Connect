using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.Profile.Request.ATE;
using Sim908Connect.Lib.Profile.Response.ATE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.Profile.Processor
{
    public class ATERequestProcessor : IProcessorFor<ATERequest>
    {
        CommandExecutor _executor;
        public ATERequestProcessor(CommandExecutor executor)
        {
            if (executor == null)
                throw new ArgumentNullException("Executor cant be null");

            _executor = executor;
        }

        public ATCommandResponseBase Process(ATERequest request)
        {
            switch (request.ATCommandMode)
            {
                case ATCommandModes.EXECUTE:
                    return ProcessExecute(request);
                case ATCommandModes.TEST:
                    throw new NotImplementedException();
                default:
                    throw new InvalidOperationException(string.Concat("Specified ATCommand Mode ", request.ATCommandMode, " is not available for ", request.BaseCommandString));
            }
        }

        private ATCommandResponseBase ProcessExecute(ATERequest request)
        {
            var response = new ATEResponse();
            var stream = _executor.Execute(request.ExecuteCommandString);
            if (String.IsNullOrWhiteSpace(stream) || stream.Replace("\n", "").Replace("\r", "").Trim() == "ERROR")
                response.Status = "ERROR";
            else
                response.Status = "OK";
            return response;
            
        }
    }
}
