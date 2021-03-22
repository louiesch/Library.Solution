using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Author> Authors {get; set;}
    public DbSet<Book> Books {get; set;}
    public DbSet<Copy> Copies {get; set;}
    public DbSet<AuthorBook> AuthorBook {get; set;}
    public DbSet<BookCopy> BookCopy {get; set;}
    public LibraryContext (DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}