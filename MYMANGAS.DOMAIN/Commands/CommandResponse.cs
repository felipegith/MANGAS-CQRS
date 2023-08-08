using MYMANGAS.DOMAIN.Commands.Contracts;

namespace MYMANGAS.DOMAIN.Commands
{
    public class CommandResponse : ICommandResponse
    {
        public CommandResponse()
        {

        }

        public CommandResponse(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public CommandResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
