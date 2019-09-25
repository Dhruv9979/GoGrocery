using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP231_Group_Project.App_Code
{
    public class Store
    {
        public ObjectId _id { get; }
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
    }
}