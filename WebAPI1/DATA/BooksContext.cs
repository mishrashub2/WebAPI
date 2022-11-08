using Microsoft.EntityFrameworkCore;

namespace WebAPI1.DATA
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
