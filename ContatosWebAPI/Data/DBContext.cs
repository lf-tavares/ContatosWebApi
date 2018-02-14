using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ContatosWebAPI.Models;

namespace ContatosWebAPI.Data
{
    public class DBContext
    {
        private IMongoDatabase _db = null;
        public IMongoDatabase Db
        {
            get { return _db; }
            set { _db = value; }
        }

        public DBContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _db = client.GetDatabase(settings.Value.Database);
        }
    }
}
