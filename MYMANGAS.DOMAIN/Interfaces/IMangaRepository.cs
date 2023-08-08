using MYMANGAS.DOMAIN.Entities;

namespace MYMANGAS.DOMAIN.Interfaces
{
    public interface IMangaRepository
    {
        Manga Create(Manga manga);
        Manga Update(Manga manga);
        Manga GetById(Guid id);
        IEnumerable<Manga> GetAll(string user);
        void Delete(Manga manga);
        
    }
}
