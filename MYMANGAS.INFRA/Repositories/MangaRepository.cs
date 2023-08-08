using Microsoft.EntityFrameworkCore;
using MYMANGAS.DOMAIN.Entities;
using MYMANGAS.DOMAIN.Interfaces;
using MYMANGAS.DOMAIN.Queries;
using MYMANGAS.INFRA.Context;

namespace MYMANGAS.INFRA.Repositories
{
    public class MangaRepository : IMangaRepository
    {
        private readonly SqlContext _context;

        public MangaRepository(SqlContext context)
        {
            _context = context;
        }

        public Manga Create(Manga manga)
        {
            _context.Mangas.Add(manga);
            _context.SaveChanges();
            return manga;
        }

        public void Delete(Manga manga)
        {
            try
            {
                _context.Mangas.Remove(manga);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new ArgumentNullException();
            }

        }

        public IEnumerable<Manga> GetAll(string user)
        {
            return _context.Mangas.AsNoTracking().Where(MangaQueries.GetAll(user)).ToList();
        }

        public Manga GetById(Guid id)
        {
            var getManga = _context.Mangas.FirstOrDefault(MangaQueries.GetById(id));

            if (getManga is null)
                return null;

            return getManga;
        }

        public Manga Update(Manga manga)
        {
            _context.Entry(manga).State = EntityState.Modified;
            _context.SaveChanges();

            return manga;
        }


    }
}
