using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LU
{
    public partial class Clerk_ViewAdjustmentDetailsUI : System.Web.UI.Page
    {
        LUEntities2 cntx = new LUEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            var q = from f in cntx.stock_adjustment
                    where f.stock_adjustment_voucher_id == "SA001"
                    select new { f.item.category.category_name, f.item.item_description, f.stock_adjustment_qty, f.stock_adjustment_price ,f.stock_adjustment_reason};
            //stock_adjustment s = q.First();
            GridView1.DataSource = q.ToList();
            GridView1.DataBind();
        }
    }
}
//f.stock_adjustment_reason 