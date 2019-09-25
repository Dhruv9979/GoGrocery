using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP231_Group_Project.App_Code
{
    public class Employee
    {
        public ObjectId _id { get; }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Postion { get; set;}
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public BsonDateTime JoiningDate { get; }
    }
}