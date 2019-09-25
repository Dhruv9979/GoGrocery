using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP231_Group_Project.App_Code
{
    public class Item
    {
        public ObjectId _id { get; }
        public int ItemID { get; set; }
        public int UPC { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}