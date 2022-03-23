
using Microsoft.Extensions.Options;

using MongoDB.Driver;

namespace Campsites.Services;

public class SitesService
{
    private readonly IMongoCollection<Site> _sitesCollection;

    public SitesService(IOptions<CampsitesDatabaseSettings> settings)
    {
        var mongoClient = new MongoClient(settings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(settings.Value.DatabaseName);

        _sitesCollection = mongoDatabase.GetCollection<Site>(settings.Value.SitesCollectionName);
    }

    public async Task<List<Site>> GetAsync() => await _sitesCollection.Find(_ => true).ToListAsync();
}