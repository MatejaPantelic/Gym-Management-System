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
    public partial class Zaposleni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TrenerBusiness trenerBusiness = new TrenerBusiness(new TrenerRepository());
            List<Trener> treners = trenerBusiness.VratiTrenere();
           
            foreach(Trener trener in treners)
            {
                HtmlGenericControl listonode = new HtmlGenericControl("TR");
                HtmlGenericControl listid = new HtmlGenericControl("TD");
                listid.Attributes.Add("scope", "row");
                listid.InnerText = trener.id_trenera.ToString();
                listonode.Controls.Add(listid);
                HtmlGenericControl listime = new HtmlGenericControl("TD");
                listime.InnerText = trener.ime;
                listonode.Controls.Add(listime);
                HtmlGenericControl listprezime = new HtmlGenericControl("TD");
                listprezime.InnerText = trener.prezime;
                listonode.Controls.Add(listprezime);
                HtmlGenericControl listel = new HtmlGenericControl("TD");
                listel.InnerText = trener.br_telefona;
                listonode.Controls.Add(listel);
                tablecontent.Controls.Add(listonode);
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}