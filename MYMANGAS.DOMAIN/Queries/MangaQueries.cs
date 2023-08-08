using MYMANGAS.DOMAIN.Entities;
using System.Linq.Expressions;

namespace MYMANGAS.DOMAIN.Queries
{
    public static class MangaQueries
    {
        public static Expression<Func<Manga, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
        
        public static Expression<Func<Manga, bool>> GetAll(string user)
        {
            return x => x.User == user;
        }
    }
}
