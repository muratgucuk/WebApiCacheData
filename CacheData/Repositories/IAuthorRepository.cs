using CacheData.Models;
using System.Threading.Tasks;

namespace CacheData.Repositories
{
    public interface IAuthorRepository
    {
        Authors Get(string name);
        Task Create(Authors author);
        Task Delete(string name);
    }
}