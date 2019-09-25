using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP231_Group_Project.App_Code
{
    public class Inventory
    {
        public ObjectId _id { get; set; }
        public int StoreID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }    
}