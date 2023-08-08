using AutoMapper;
using MYMANGAS.APPLICATION.Models;
using MYMANGAS.APPLICATION.Services.Contracts;
using MYMANGAS.DOMAIN.Commands;
using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Entities;
using MYMANGAS.DOMAIN.Handles;
using MYMANGAS.DOMAIN.Interfaces;

namespace MYMANGAS.APPLICATION.Services.Implementations
{
    public class MangaService : IMangaService
    {
        private readonly IMangaRepository _repository;
        private readonly MangaHandle _handle;
        private readonly IMapper _mapper;

        public MangaService(IMangaRepository repository, MangaHandle handle, IMapper mapper)
        {
            _repository = repository;
            _handle = handle;
            _mapper = mapper;
        }

        public ICommandResponse Create(MangaViewModel manga)
        {
            var viewModelToCommand = _mapper.Map<CreateMangaCommand>(manga);

            var getHandle  = _handle.Handle(viewModelToCommand);

            return getHandle;
        }

        public ICommandResponse Delete(MangaViewModel manga)
        {
            var viewModelIdToCommand = _mapper.Map<DeleteMangaCommand>(manga);

            var getHandle = _handle.Handle(viewModelIdToCommand);

            return getHandle;
        }

        public ICommandResponse GetAll(string user)
        {
            var getAll = _repository.GetAll(user);

            if (!getAll.Any())
                return null;

            var commandResponse = new CommandResponse(true, "Requisição realizada com sucesso", getAll);
            
            return commandResponse;
        }

        public ICommandResponse GetById(MangaViewModel manga)
        {
            var viewModelToDomain = _mapper.Map<Manga>(manga);

            var getManga = _repository.GetById(viewModelToDomain.Id);

            if (getManga is null)
                return new CommandResponse(false, "Erro ao buscar o mangá");

            return new CommandResponse(true, "Requisição realizada com sucesso", getManga);
        }

        public ICommandResponse UpdateName(MangaViewModel manga)
        {
            var viewModelToCommand = _mapper.Map<UpdateMangaCommand>(manga);

            var getHandle = _handle.Handle(viewModelToCommand);

            return getHandle;
        }

        public ICommandResponse UpdateRead(MangaViewModel manga)
        {
            var viewModelToCommand = _mapper.Map<UpdateMangaReadCommand>(manga);

            var getHandle = _handle.Handle(viewModelToCommand);

            return getHandle;
        }
    }
}
