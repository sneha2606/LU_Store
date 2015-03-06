using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LU
{
    public class ApprovePurchaseOrder_Controller
    {
        protected void getAllPurchaseOrderDetails()
        {
            // entities : purchaseorder,purchase_order_details,supplier
            // for what : Display all purchase orders (POID,Status,Date,Orderby,Supplier)
            // expected type:
            //{ purchaseorder+purchase_order_details+supplier} >> request for a business entity////
            // { combined result..}
        }
        protected void getSinglePurchaseOrderDetails()
        {
            // entities : purchaseorder,purchase_order_details,supplier,item,supplierlist
            // for what : Display details for single purchase order - item,desc,quantit,price,priceamount,po number,supplier,orderby,approvedby
            // expected type:
            //{ purchaseorder+purchase_order_details+supplier,item,supplierlist} >> request for a business entity////
            // { combined result..}
        }

        protected void setPurchaseOrderDetails() //used two times for Approved and Rejected status
        {
            // entities : purchaseorder
            // for what : Saving purchaseorder status
            // expected type:purchaseorder
            
        }
    }
}