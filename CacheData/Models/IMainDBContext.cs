using System.Data.Entity;
using CacheData.Models;
using System.Threading.Tasks;

public interface IMainDBContext
{
    DbSet<Authors> Authors { get; set; }
    DbSet<Books> Books { get; set; }

    void SaveChanges();
    Task SaveChangesAsync();
}