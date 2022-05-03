using Microsoft.EntityFrameworkCore;
using testnexus.Entitys;

namespace testnexus.Context
{
    public class ContextBook : DbContext
    {
        public ContextBook(DbContextOptions<ContextBook> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial>Editorials { get; set; }
        public DbSet<Book>books { get; set; }

    }
}
