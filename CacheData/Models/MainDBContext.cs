using CacheData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

public class MainDBContext : DbContext, IMainDBContext
{
    public MainDBContext()
        : base("name=MainDBContext")
    {
    }

    public DbSet<Authors> Authors { get; set; }
    public DbSet<Books> Books { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Authors>()
            .HasMany<Books>(f => f.Books)
            .WithRequired(f => f.Author)
            .HasForeignKey(f => f.Author_Id);
    }

    void IMainDBContext.SaveChanges()
    {
        SaveChanges();
    }

    async Task IMainDBContext.SaveChangesAsync()
    {
        await SaveChangesAsync();
    }
}
