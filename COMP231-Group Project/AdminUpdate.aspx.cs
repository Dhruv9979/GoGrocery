using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Data;
using System.Configuration;
using COMP231_Group_Project.App_Code;

namespace COMP231_Group_Project
{
    public partial class AdminUpdate : System.Web.UI.Page
    {
        DAL dal = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userType"] != null)
            {
                if (!Session["userType"].Equals("admin"))
                {
                    Response.Redirect("StoreSelect.aspx");
                }
            }
            if (!IsPostBack)
            {
                LoadInventory();
            }
        }

        private void LoadInventory()
        {
            try
            {
                GridView1.DataSource = dal.GetInventoryList().ToList();
                GridView1.DataBind();
            }
            catch (Exception) { }
        }

        protected void Save(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            if (hdn.Value == "Edit")
            {
                if (ViewState["_idEdit"].ToString() != "")
                    inventory._id = ObjectId.Parse(ViewState["_idEdit"].ToString());

                inventory.StoreID = Convert.ToInt32(txtStoreId.Text);
                inventory.ItemID = Convert.ToInt32(txtItemId.Text);
                inventory.ItemName = txtItemName.Text;
                inventory.Price = Convert.ToDouble(txtPrice.Text);
                inventory.Quantity = Convert.ToInt32(txtQuantity.Text);
                //dal.insert(inventory);
                // inventory._id = Xid;

                dal.UpdateInventory(inventory);
                LoadInventory();
            }
            else
            {
                //Inventory inventory = new Inventory();
                inventory.StoreID = Convert.ToInt32(txtStoreId.Text);
                inventory.ItemID = Convert.ToInt32(txtItemId.Text);
                inventory.ItemName = txtItemName.Text;
                inventory.Price = Convert.ToDouble(txtPrice.Text);
                inventory.Quantity = Convert.ToInt32(txtQuantity.Text);
                dal.InsertInventory(inventory);
                LoadInventory();
            }
        }
        protected void Add(object sender, EventArgs e)
        {
            txtStoreId.Text = string.Empty;
            txtItemId.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            popup.Show();
        }
        public void Edit(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            hdn.Value = "Edit";
            using (GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent)
            {

                txtStoreId.Text = row.Cells[0].Text;
                txtItemId.Text = row.Cells[1].Text;
                txtItemName.Text = row.Cells[2].Text;
                txtPrice.Text = row.Cells[3].Text;
                txtQuantity.Text = row.Cells[4].Text;
                popup.Show();
            }
            ViewState["_idEdit"] = btn.CommandArgument;
        }
        protected void delete(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Inventory inventory = new Inventory();
            var x = inventory._id;
            if (btn.Text == "Delete")
            {
                dal.DeleteInventory(ObjectId.Parse(btn.CommandArgument));
                LoadInventory();
            }
            else
            {
                hdn.Value = "Edit";
            }
        }
    }
}