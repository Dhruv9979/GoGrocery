using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization;

namespace COMP231_Group_Project.App_Code
{
    public class DAL
    {
        public static MongoClient mongo;
        public static MongoServer server;
        public static MongoDatabase myDB;
        public DAL()
        {
            mongo = new MongoClient();
            server = mongo.GetServer();
            myDB = server.GetDatabase("GoGrocery");
            //MongoCollection<Inventory> inventories = myDB.GetCollection<Inventory>("inventory");
        }

        #region Inventory

        public List<Inventory> GetInventoryList()
        {
            List<Inventory> list = new List<Inventory>();
            var collection = myDB.GetCollection<Inventory>("inventory");
            foreach (Inventory inventory in collection.FindAll())
            {
                list.Add(inventory);
            }
            return list;
        }
        public void InsertInventory(Inventory inventory)
        {
            try
            {
                MongoCollection<Inventory> collection = myDB.GetCollection<Inventory>("inventory");
                BsonDocument Inventory = new BsonDocument{
                    {"StoreID",inventory.StoreID},
                    {"ItemID",  inventory.ItemID},
                    {"ItemName", inventory.ItemName},
                    {"Price", inventory.Price},
                    {"Quantity",inventory.Quantity}
                };
                collection.Insert(Inventory);
            }
            catch { };
        }

        public void UpdateInventory(Inventory inventory)
        {
            MongoCollection<Inventory> collection = myDB.GetCollection<Inventory>("inventory");
            IMongoQuery query = Query.EQ("_id", inventory._id);
            IMongoUpdate update = MongoDB.Driver.Builders.Update.Set("StoreID", inventory.StoreID)
                                                                 .Set("ItemID", inventory.ItemID)
                                                                 .Set("ItemName", inventory.ItemName)
                                                                 .Set("Price", inventory.Price)
                                                                 .Set("Quantity", inventory.Quantity);
            collection.Update(query, update);
        }

        public void DeleteInventory(ObjectId id)
        {
            MongoCollection<Inventory> collection = myDB.GetCollection<Inventory>("inventory");
            IMongoQuery query = Query.EQ("_id", id);
            collection.Remove(query);
        }

        #endregion

        #region User

        public void InsertUser(User user)
        {
            try
            {
                MongoCollection<User> collection = myDB.GetCollection<User>("users");
                BsonDocument userDocument = new BsonDocument{
                    {"FullName",user.FullName},
                    {"Username",  user.Username},
                    {"Email", user.Email},
                    {"Password", user.Password},
                    {"Type", user.Type}
                };
                collection.Insert(userDocument);
            }
            catch { };
        }
        #endregion
    }
}