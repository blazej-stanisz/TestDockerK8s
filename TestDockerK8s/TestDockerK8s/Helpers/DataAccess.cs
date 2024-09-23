using MongoDB.Driver;
using MongoDB.Driver.Core.Servers;
using TestDockerK8s.Models.DatabaseModels;

namespace TestDockerK8s.Helpers
{
    public class DataAccess : IDataAccess
    {
        MongoClient _client;
        ServerDescription _server;
        IMongoDatabase _db;

        public DataAccess()
        {
            try
            {
                _client = new MongoClient("mongodb://localhost:27017?serverSelectionTimeoutMS=300&connectTimeoutMS=300&socketTimeoutMS=300");
                _db = _client.GetDatabase("TestDockerK8s");
            }
            catch 
            { 
               
            }
        }

        public List<Clients> GetClientNames()
        {
            return _db.GetCollection<Clients>("Clients").Aggregate().ToList();
        }

        /*
        public Product GetProduct(ObjectId id)
        {
            var res = Query<Product>.EQ(p => p.Id, id);
            return _db.GetCollection<Product>("Products").FindOne(res);
        }

        public Product Create(Product p)
        {
            _db.GetCollection<Product>("Products").Save(p);
            return p;
        }

        public void Update(ObjectId id, Product p)
        {
            p.Id = id;
            var res = Query<Product>.EQ(pd => pd.Id, id);
            var operation = Update<Product>.Replace(p);
            _db.GetCollection<Product>("Products").Update(res, operation);
        }
        public void Remove(ObjectId id)
        {
            var res = Query<Product>.EQ(e => e.Id, id);
            var operation = _db.GetCollection<Product>("Products").Remove(res);
        }
        */
    }
}
