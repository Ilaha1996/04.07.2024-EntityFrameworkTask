using EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFLibrary.DAL;

public class LibraryDBContex : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ILAHA\\SQLEXPRESS01;Database=EFLibraryDB;Trusted_Connection=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}
