using Fit2.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit2.Database
{
    sealed class DBQ
    {
        private static MongoClient mongo;

        private DBQ()
        {
               mongo = new MongoClient("APIKEY");
        }

        private static readonly Lazy<DBQ> lazy = new Lazy<DBQ>(() => new DBQ());
        public static DBQ Instance
        {
            get
            {
                return lazy.Value;
            }
        }


        public Client ClientBarcode(string code)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var filter = Builders<Client>.Filter.Eq("barcode", code);
            return db.GetCollection<Client>("Client").Find(filter).First();
        }

        public int AdmissionCount(ObjectId id)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var filter = Builders<Admission>.Filter.Eq("clientTicketId", id);
            return (int)db.GetCollection<Admission>("Admission").CountDocuments(filter);
        }

        public List<Admission> Admissions(ObjectId id)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var filter = Builders<Admission>.Filter.Eq("clientTicketId", id);
            return db.GetCollection<Admission>("Admission").Find(filter).ToList().OrderBy(x => x.date).ToList();
        }

        public List<ClientTicket> ClientTickets(ObjectId id)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var filter = Builders<ClientTicket>.Filter.Eq("clientId", id);
            return db.GetCollection<ClientTicket>("ClientTicket").Find(filter).ToList();
        }

        public T Insert<T>(T t)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            db.GetCollection<T>(t.GetType().Name).InsertOne(t);
            return t;
        }

        public T Update<T>(T t, ObjectId id)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var filter = Builders<T>.Filter.Eq("_id", id);
            db.GetCollection<T>(t.GetType().Name).ReplaceOne(filter, t);
            return t;
        }

        public List<T> GetAll<T>()
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            return db.GetCollection<T>(typeof(T).Name).Find(_ => true).ToList<T>();
        }

        public T GetById<T>(ObjectId id)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var filter = Builders<T>.Filter.Eq("_id", id);
            return db.GetCollection<T>(typeof(T).Name).Find(filter).FirstOrDefault();
        }

        public List<T> GetByName<T>(string value) where T: BaseModel
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            var builder = Builders<T>.Filter;
            var filter = builder.Where(x => x.name.Contains(value));
            return db.GetCollection<T>(typeof(T).Name).Find(filter).ToList<T>();
        }

        static private string GetValObjDy(object obj, string propertyName)
        {
            return (string)obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        public User GetUserByNameAndPassword(string username, string password)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            return db.GetCollection<User>("User").Find(x=>x.name == username && x.password == password).FirstOrDefault();
        }

        public Client InsertClient(Client client)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            db.GetCollection<Client>("Client").InsertOneAsync(client);
            return client;
        }

        public bool ClientAlreadyExists(string cnp)
        {
            IMongoDatabase db = mongo.GetDatabase("FitDB");
            return db.GetCollection<Client>("Client").Find(x => x.cnp == cnp).CountDocuments()>0;
        }
    }
}
