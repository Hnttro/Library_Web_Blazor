using Microsoft.EntityFrameworkCore;
using NT_21K4080057.Components.Models;

namespace NT_21K4080057.Components.Data
{
    public class BookDbcontext : DbContext
    {
        public BookDbcontext(DbContextOptions<BookDbcontext> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<BorrowingRecord> BorrowingRecord { get; set; }
    }
}
