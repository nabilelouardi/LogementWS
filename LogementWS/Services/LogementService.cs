﻿using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace LogementWS.Services
{
    public class LogementService
    {
        //my changes
        private readonly IMongoCollection<Logement> logements;

        public LogementService(ILogementsSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            logements = database.GetCollection<Logement>(settings.LogementCollection);
        }

        public List<Logement> Get() =>
            logements.Find(logement => true).ToList();
    }
}
