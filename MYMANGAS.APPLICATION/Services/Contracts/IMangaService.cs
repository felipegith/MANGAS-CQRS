using MYMANGAS.APPLICATION.Models;
using MYMANGAS.DOMAIN.Commands;
using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Entities;

namespace MYMANGAS.APPLICATION.Services.Contracts
{
    public interface IMangaService
    {
        ICommandResponse Create(MangaViewModel manga);
        ICommandResponse UpdateName(MangaViewModel manga);
        ICommandResponse UpdateRead(MangaViewModel manga);
        ICommandResponse GetById(MangaViewModel manga);
        ICommandResponse GetAll(string user);
        ICommandResponse Delete(MangaViewModel manga);
    }
}
