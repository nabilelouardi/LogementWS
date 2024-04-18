using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace LogementWS.Services
{
    public class LogementService
    {

        private readonly IMongoCollection<Logement> logements;

        public LogementService(ILogementsSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            //CHANG1

            logements = database.GetCollection<Logement>(settings.LogementCollection);
        }

        public List<Logement> Get() =>
            logements.Find(logement => true).ToList();
    }
}
