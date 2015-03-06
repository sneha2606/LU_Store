using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LU
{
    public partial class Clerk_NewAdjustmentVoucherUI : System.Web.UI.Page
    {
        LUEntities2 cntx = new LUEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Category();
            }
           


            
                //String temp;
                //temp = Category_DropDownList1.Text;

                //var p = from f in cntx.categories
                //        where f.category_name == temp
                //        select f.category_id;


                //DropDownList_item.DataSource = p.ToList();
                //DropDownList_item.DataBind();
                //int id;

                //List<int> c = p.ToList();

                //foreach (var i in c)
                //{
                //    id = i;

                //    var r = from f in cntx.items
                //            where f.category_category_id == id
                //            select f.item_description;

                //    DropDownList_item.DataSource = r.ToList();
                //    DropDownList_item.DataBind();
                //}

            
            //var r=from f in cntx.items
            //      where f.category_category_id==
            //      select f.item_description;
        }

       
        private void Category()
        {
             var q = from f in cntx.categories
                    select f.category_name;


            Category_DropDownList1.DataSource = q.ToList();
            Category_DropDownList1.DataBind();

            
        }
        protected void Category_DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp;
            temp = Category_DropDownList1.SelectedItem.ToString();

            var p = from f in cntx.categories
                    where f.category_name == temp
                    select f.category_id;



            
            DropDownList_item.DataSource = p.ToList();
            DropDownList_item.DataBind();
            

            //List<int> c = p.ToList();

            //foreach (var i in c)
            //{
            //    id = i;

            //    var r = from f in cntx.items
            //            where f.category_category_id == id
            //            select f.item_description;

            //    DropDownList_item.DataSource = r.ToList();
            //    DropDownList_item.DataBind();
            //}

        }

        protected void DropDownList_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            String h = "";
        }

        

        protected void Category_DropDownList1_IndexChanged1(object sender, EventArgs e)
        {
            String h = "";

            String temp;
            temp = Category_DropDownList1.SelectedItem.ToString();

            var p = from f in cntx.categories
                    where f.category_name == temp
                    select f.category_id;


            List<int> c = p.ToList();
            int id; int l;
            foreach (var i in c)
            {
                id =Convert.ToInt32(i) ;
                //Label_BalanceStock.Text = id.ToString();
                var r = from f in cntx.items
                        where f.category_category_id == id
                        select f.item_description;

                DropDownList_item.DataSource = r.ToList();
                DropDownList_item.DataBind();


                var u = from f in cntx.items
                        where f.category_category_id == id
                        select f.uom.uom_name;

                List<String> uom = u.ToList();
                
                Label_uom.Text = uom.ToString();
                //Label_uom.DataBind();
                

                //var u=from f in cntx.items
                //      where f.category_category_id==id
                //      select f.uom.uom_name;

                //Label_uom.Text = u.ToList().ToString();
                //Label_uom.DataBind();
            }

            //DropDownList_item.DataSource = p.ToList();
            //DropDownList_item.DataBind();
        }
    }
}