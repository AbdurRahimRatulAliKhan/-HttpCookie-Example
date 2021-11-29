using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_WebApp_Example
{
    public partial class WebControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("student");
            cookie.Value = "Ratul Ali";
            Response.Cookies.Add(cookie);
            var co_val = Response.Cookies["student"].Value;
            Label1.Text = co_val;
        }
    }
}