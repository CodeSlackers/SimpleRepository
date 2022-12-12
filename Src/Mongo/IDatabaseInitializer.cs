using System.Threading.Tasks;

namespace SimpleRepository.Mongo
{
    public interface IDatabaseInitializer
    {
        Task InitializeAsync();
    }
}