using AutoMapper;
using MYMANGAS.APPLICATION.Models;
using MYMANGAS.DOMAIN.Commands;
using MYMANGAS.DOMAIN.Commands.Contracts;
using MYMANGAS.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYMANGAS.APPLICATION.Mapping
{
    public class ViewModelToCommand : Profile
    {
        public ViewModelToCommand()
        {
            CreateMap<MangaViewModel, CreateMangaCommand>();
            CreateMap<MangaViewModel, UpdateMangaCommand>();
            CreateMap<MangaViewModel, DeleteMangaCommand>();
            CreateMap<MangaViewModel, UpdateMangaReadCommand>();
            CreateMap<MangaViewModel, CommandResponse>();

        }
    }
}
