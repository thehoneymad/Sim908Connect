using Sim908Connect.Lib.Base;
using Sim908Connect.Lib.GSM.Request.AT_CGSN;
using Sim908Connect.Lib.GSM.Response.AT_CGSN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.GSM.Processor
{
    public class AT_CGSNRequestProcessor : IProcessorFor<AT_CGSNRequest>
    {
        CommandExecutor _executor;
        public AT_CGSNRequestProcessor(CommandExecutor executor)
        {
            if (executor == null)
                throw new ArgumentNullException("Executor cant be null");

            _executor = executor;
        }
        public ATCommandResponseBase Process(AT_CGSNRequest request)
        {
           switch(request.ATCommandMode)
            {
                case ATCommandModes.EXECUTE:
                    return ProcessExecute(request);
                case ATCommandModes.TEST:
                    throw new NotImplementedException();
                default:
                    throw new InvalidOperationException(string.Concat("Specified ATCommand Mode ", request.ATCommandMode, " is not available for ", request.BaseCommandString));
            }
        }

        private ATCommandResponseBase ProcessExecute(AT_CGSNRequest request)
        {
            Console.WriteLine("Processing "+request.ExecuteCommandString);
            var data = _executor.Execute(request.ExecuteCommandString, request.Timeout);
            Console.WriteLine(data);
            string[] reponseArray = data.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var Response = new AT_CGSNExecuteResponse();
            Response.IMEI = reponseArray.First().Trim();
            Response.Status = reponseArray.Last().Trim();

            return Response;
        }
    }
}
