using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET10Course.Model.Context
{
    public class MSSQLCcontext : DbContext
    {
        public MSSQLCcontext(DbContextOptions<MSSQLCcontext> options)
            : base(options){}
        public DbSet<Book> Persons { get; set; }
    }
}