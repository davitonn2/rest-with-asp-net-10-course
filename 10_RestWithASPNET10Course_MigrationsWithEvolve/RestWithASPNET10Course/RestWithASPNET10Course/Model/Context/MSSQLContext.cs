using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET10Course.Model.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext(DbContextOptions<MSSQLContext> options)
            : base(options){}
        public DbSet<Book> Persons { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}