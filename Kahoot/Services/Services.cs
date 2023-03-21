
using MongoDB.Driver;
using System;
using Kahoot.Configuration;
using Kahoot.Models;

namespace Kahoot.Services
{
    public class KahootService
{
    private readonly IMongoDatabase _database;

    public KahootService(IMongoDatabase database)
    {
        _database = database;
    }

    public async Task CreateKahoot(KahootModel kahoot)
    {
        var collection = _database.GetCollection<KahootModel>("kahoots");
        await collection.InsertOneAsync(kahoot);
    }

}
}