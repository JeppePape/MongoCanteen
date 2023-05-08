using MongoDB.Driver;
using CanteenDB.Models;
using Microsoft.Extensions.Options;

namespace CanteenDB.Services
{
    public class CanteenService
    {
        private readonly IMongoCollection<Canteen> _CanteenCollection;

        public CanteenService(IOptions<CanteenDatabaseSettings> canteenDatabaseSettings)

        {
            var mongoClient = new MongoClient(
                canteenDatabaseSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(
                canteenDatabaseSettings.Value.DatabaseName);
            _CanteenCollection = mongoDatabase.GetCollection<Canteen>(
                canteenDatabaseSettings.Value.CanteenCollectionName);
        }

        public async Task<List<Canteen>> GetAsync() =>
            await _CanteenCollection.Find(_ => true).ToListAsync();
        public async Task<Canteen?> GetAsync(string id) =>
            await _CanteenCollection.Find<Canteen>(canteen => canteen.CanteenName == id).FirstOrDefaultAsync();
        public async Task CreateAsync(Canteen newCanteen) =>
            await _CanteenCollection.InsertOneAsync(newCanteen);

        public async Task UpdateAsync(string id, Canteen updatedCanteen) =>
            await _CanteenCollection.ReplaceOneAsync(x => x.CanteenName == id, updatedCanteen);

        public async Task RemoveAsync(string id) =>
            await _CanteenCollection.DeleteOneAsync(x => x.CanteenName == id);
    }
}
