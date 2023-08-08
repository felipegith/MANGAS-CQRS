using MYMANGAS.DOMAIN.Commands;
using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Entities;
using MYMANGAS.DOMAIN.Handles.Contracts;
using MYMANGAS.DOMAIN.Interfaces;

namespace MYMANGAS.DOMAIN.Handles
{
    public class MangaHandle : IHandle<CreateMangaCommand>,
                               IHandle<UpdateMangaCommand>,
                               IHandle<DeleteMangaCommand>,
                               IHandle<UpdateMangaReadCommand>
    {
        private readonly IMangaRepository _repository;

        public MangaHandle(IMangaRepository repository)
        {
            _repository = repository;
        }

        public ICommandResponse Handle(CreateMangaCommand command)
        {

            if (!command.Validate())
            {
                return new CommandResponse(false, "Não foi possível realizar o cadastro", command);
            }

            var createManga = new Manga(command.User, command.Name, command.Description, command.Rating, command.Read);

            _repository.Create(createManga);

            return new CommandResponse(true, "Requisição realizada com sucesso", createManga);

        }

        public ICommandResponse Handle(UpdateMangaCommand command)
        {
            if (!command.Validate())
            {
                return new CommandResponse(false, "Não foi possível realizar o cadastro", command);
            }

            var manga = _repository.GetById(command.Id);

            manga.UpdateMangaName(command.Name);

            _repository.Update(manga);

            return new CommandResponse(true, "Requisição realizada com sucesso", manga);
        }

        public ICommandResponse Handle(DeleteMangaCommand command)
        {
            if (!command.Validate())
            {
                return new CommandResponse(false, "Não foi possível excluir o manga");
            }

            var manga = _repository.GetById(command.Id);

            _repository.Delete(manga);

            return new CommandResponse(true, "Requisição realizada com sucesso");
        }

        public ICommandResponse Handle(UpdateMangaReadCommand command)
        {
            if (!command.Validate())
            {
                return new CommandResponse(false, "Não foi possível atualizar o manga");
            }

            var manga = _repository.GetById(command.Id);

            manga.UpdateReadManga(command.Read);

            _repository.Update(manga);

            return new CommandResponse(true, "Requisição realizada com sucesso", manga);

        }
    }
}
