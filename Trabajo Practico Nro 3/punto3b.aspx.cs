using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp_grupal_3
{
    public partial class punto3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tema;
            tema = Request.QueryString["tem"];
            

            SqlConnection cn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from libros where idtema="+tema, cn);

            SqlDataReader dr = cmd.ExecuteReader();
            grdtema.DataSource = dr;
  
           
            grdtema.DataBind();

            cn.Close();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("punto3A.aspx");
        }
    }
}