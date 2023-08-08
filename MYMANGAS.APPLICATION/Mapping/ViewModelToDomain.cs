using AutoMapper;
using MYMANGAS.APPLICATION.Models;
using MYMANGAS.DOMAIN.Entities;

namespace MYMANGAS.APPLICATION.Mapping
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<MangaViewModel, Manga>();
        }
    }
}
