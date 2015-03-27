using SolutionOra2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolutionOra2.Web
{
    public partial class Kezdolap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<MyMenuItem> menuItems = new List<MyMenuItem>();
                menuItems.Add(new MyMenuItem() { Cim = "Home", Link = "/Kezdolap.aspx" });
                menuItems.Add(new MyMenuItem() { Cim = "Services", Link = "/Services.aspx" });
                menuItems.Add(new MyMenuItem() { Cim = "Contact us", Link = "http://www.index.hu" });

                ReaperMenu.DataSource = menuItems;
                ReaperMenu.DataBind();
            }
        }
    }
}