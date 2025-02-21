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
        }
    }
}