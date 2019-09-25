using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Web.UI;
using COMP231_Group_Project.App_Code;

namespace COMP231_Group_Project
{
    public partial class StoreSelect : System.Web.UI.Page
    {
        DAL getMongo = new DAL();
        MongoCollection<Inventory> inventories = DAL.myDB.GetCollection<Inventory>("inventory");
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateStore1();
            PopulateStore2();
            PopulateStore3();
            //chkListStore1.Items.Add(inventoryList);
        }

        private void PopulateStore1()
        {
            List<Inventory> inventoryList = new List<Inventory>();

            foreach (Inventory item in inventories.FindAll())
            {
                if (item.StoreID == 1)
                {
                    // chkListStore1.Items.Add("Name: " + item.ItemName + "Quantity: " + item.Quantity);
                    inventoryList.Add(item);
                }
            }
            gridStore1.DataSource = inventoryList;
            gridStore1.DataBind();
        }

        private void PopulateStore2()
        {
            List<Inventory> inventoryList = new List<Inventory>();
            foreach (Inventory item in inventories.FindAll())
            {
                if (item.StoreID == 2)
                {
                    // chkListStore1.Items.Add("Name: " + item.ItemName + "Quantity: " + item.Quantity);
                    inventoryList.Add(item);
                }
            }
            gridStore2.DataSource = inventoryList;
            gridStore2.DataBind();
        }

        private void PopulateStore3()
        {
            List<Inventory> inventoryList = new List<Inventory>();
            foreach (Inventory item in inventories.FindAll())
            {
                if (item.StoreID == 3)
                {
                    // chkListStore1.Items.Add("Name: " + item.ItemName + "Quantity: " + item.Quantity);
                    inventoryList.Add(item);
                }
            }

            gridStore3.DataSource = inventoryList;
            gridStore3.DataBind();
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "text", "Func()", true);
        }
    }
}