using MYMANGAS.DOMAIN.Commands.Contracts;

namespace MYMANGAS.DOMAIN.Handles.Contracts
{
    public interface IHandle<T> where T  : ICommand
    {
        ICommandResponse Handle(T command);
    }
}
