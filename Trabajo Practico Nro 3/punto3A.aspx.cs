using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_grupal_3
{
    public partial class punto3A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("punto3b.aspx?tem=" + ddltema.SelectedValue);
        }
    }
}