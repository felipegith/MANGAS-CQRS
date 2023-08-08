using AutoMapper;
using MYMANGAS.APPLICATION.Models;
using MYMANGAS.DOMAIN.Commands;
using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Entities;

namespace MYMANGAS.APPLICATION.Mapping
{
    public class CommandToViewModel : Profile
    {
        public CommandToViewModel()
        {
            CreateMap<CreateMangaCommand, MangaViewModel>();
            CreateMap<UpdateMangaCommand, MangaViewModel>();
            CreateMap<DeleteMangaCommand, MangaViewModel>();
            CreateMap<UpdateMangaReadCommand, MangaViewModel>();
            CreateMap<CommandResponse, MangaViewModel>();


            CreateMap<Manga, MangaViewModel>();


        }
    }
}
