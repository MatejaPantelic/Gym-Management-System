using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeretanawWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Zaposleni.aspx");
        }

        protected void Unnamed_ServerClick1(object sender, EventArgs e)
        {
            Response.Redirect("Vezbe.aspx");
        }
    }
}