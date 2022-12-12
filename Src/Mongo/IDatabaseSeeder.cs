using System.Threading.Tasks;

namespace SimpleRepository.Mongo
{
    public interface IDatabaseSeeder
    {
        /// <summary>
        /// Seed Async
        /// </summary>
        /// <returns>Ansync completion</returns>
        Task SeedAsync();

    }
}