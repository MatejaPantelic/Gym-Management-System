using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TeretanaBusiness;
using TeretanaData;

namespace TeretanawWeb
{
    public partial class Korisnici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VezbaBusiness vezbaBusiness = new VezbaBusiness(new VezbaRepository());
            List<Vezba> vezbe = vezbaBusiness.CitanjeVezbi();

            foreach (Vezba vezba in vezbe)
            {
                HtmlGenericControl listonode = new HtmlGenericControl("TR");
                HtmlGenericControl listid = new HtmlGenericControl("TD");
                listid.Attributes.Add("scope", "row");
                listid.InnerText = vezba.naziv;
                listonode.Controls.Add(listid);
                HtmlGenericControl listime = new HtmlGenericControl("TD");
                listime.InnerText = vezba.broj_ponavljanja.ToString();
                listonode.Controls.Add(listime);
                HtmlGenericControl listprezime = new HtmlGenericControl("TD");
                listprezime.InnerText = vezba.broj_serija.ToString();
                listonode.Controls.Add(listprezime);
                HtmlGenericControl listel = new HtmlGenericControl("TD");
                listel.InnerText = vezba.regija_tela;
                listonode.Controls.Add(listel);
                tablecontent.Controls.Add(listonode);

            }
        }
        protected void btn2_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}