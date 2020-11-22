using System;
using System.Linq;
using System.Collections.Generic;
// mongodb
using MongoDB.Bson;
using MongoDB.Driver;

namespace BluewayWinForms.UI.Database
{
    public class MongoCRUD
    {
        string databaseName = "propass";

        private IMongoDatabase db;

        public MongoCRUD()
        {
            var client = new MongoClient("mongodb+srv://can:ergenekon2020@database1.r6vau.azure.mongodb.net/test?authSource=admin&replicaSet=atlas-wlm0la-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true");
            
            db = client.GetDatabase(databaseName);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        public T Login<T>(string table, string name, string password)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Name", name);
            filter = filter & (Builders<T>.Filter.Eq("Password", password));

            return collection.Find(filter).FirstOrDefault();
        }

        public void DeleteRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.DeleteOne(filter);
        }
    }
}