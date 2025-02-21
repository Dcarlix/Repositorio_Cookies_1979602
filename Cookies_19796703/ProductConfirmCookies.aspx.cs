using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies_19796703
{
    public partial class ProductConfirmCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategory.SelectedValue = Request.Cookies["ddlCategory"].Value;
            ddlSupplier.SelectedValue = Request.Cookies["ddlSupplier"].Value;
            lblProduct.Text = Request.Cookies["strProduct"].Value;
            textArea1.InnerText = Request.Cookies["strDescription"].Value;
            lblImage.Text = Request.Cookies["strImage"].Value;
            Decimal decPrice = Convert.ToDecimal(Request.Cookies["decPrice"].Value);
            lblPrice.Text = decPrice.ToString("c");
            lblNumberInStock.Text = Request.Cookies["bytNumberInStock"].Value;
            lblNumberOnOrder.Text = Request.Cookies["bytNumberOnOrder"].Value;
            lblReorderLevel.Text = Request.Cookies["bytReorderLevel"].Value;
            Byte bytNumberInStock = Convert.ToByte(Request.Cookies["bytNumberInStock"].Value);
            Byte bytNumberOnOrder = Convert.ToByte(Request.Cookies["bytNumberOnOrder"].Value);
            Decimal decValueInStock = decPrice * bytNumberInStock;
            Decimal decValueOnOrder = decPrice * bytNumberOnOrder;
            lblValueInStock.Text = decValueInStock.ToString("c");
            lblValueOnOrder.Text = decValueOnOrder.ToString("c");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cookies.aspx");
        }
    }
}