using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyLibraryDb : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9F6IC4T\SQLEXPRESS;
Initial Catalog=MyLibraryDb
;Integrated Security=true");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
