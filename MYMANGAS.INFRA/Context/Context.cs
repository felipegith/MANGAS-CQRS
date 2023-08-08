using Microsoft.EntityFrameworkCore;
using MYMANGAS.DOMAIN.Entities;

namespace MYMANGAS.INFRA.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }
        public SqlContext()
        {

        }
        public DbSet<Manga> Mangas { get; set; }
    }
}
