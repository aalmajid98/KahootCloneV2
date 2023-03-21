using MongoDB.Driver;
using System;


namespace Kahoot.Configuration 
{
// Connect to the MongoDB database
    public class DbConnection
    {
        public MongoClient Client { get; set; }
        public IMongoDatabase Database { get; set; }
        public DbConnection()
        {
            Client = new MongoClient("	mongodb://127.0.0.1:27017/?directConnection=true&serverSelectionTimeoutMS=2000&appName=mongosh+1.8.0");
            Database = Client.GetDatabase("kahootdb");
        }
    }
}



