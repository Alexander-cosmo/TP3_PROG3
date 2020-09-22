using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp3programacion3
{
    public partial class Aplicacion1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (IsPostBack == false)
            {
                cargarDdl();

            }
        }

        private void cargarDdl ()
        {
            ddlProvincia1.DataSource = consultar("SELECT * FROM dbo.Provincias");
            ddlProvincia1.DataTextField = "NombreProvincia";
            ddlProvincia1.DataValueField = "IdProvincia";
            ddlProvincia1.DataBind();
            ddlProvincia1.Items.Insert(0, new ListItem("[SELECCIONE PROVINCIA]", "0"));
            ddlProvincia2.Items.Insert(0, new ListItem("[SELECCIONE PROVINCIA]", "0"));
            ddlLocalidad1.Items.Insert(0, new ListItem("[SELECCIONE LOCALIDAD]", "0"));
            ddlLocalidad2.Items.Insert(0, new ListItem("[SELECCIONE LOCALIDAD]", "0"));

        }

        protected void ddlLocalidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddlProvincia2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        protected void provinciaSeleccionada1(object sender, EventArgs e)
        {
            
               
            
            
                int idProvincia = Convert.ToInt32(ddlProvincia1.SelectedValue);
                ddlLocalidad1.DataSource = consultar("SELECT * FROM dbo.Localidades WHERE IdProvincia =" + idProvincia);
                ddlLocalidad1.DataTextField = "NombreLocalidad";
                ddlLocalidad1.DataValueField = "IdLocalidad";
                ddlLocalidad1.DataBind();
                ddlLocalidad1.Items.Insert(0, new ListItem("[SELECCIONAR LOCALIDAD]", "0"));
            
            }

        protected void localidadSeleccionada1(object sender, EventArgs e)
        {
            int idProvincia = Convert.ToInt32(ddlProvincia1.SelectedValue);
            ddlProvincia2.DataSource = consultar("SELECT * FROM dbo.Provincias WHERE IdProvincia !=" + idProvincia);
            ddlProvincia2.DataTextField = "NombreProvincia";
            ddlProvincia2.DataValueField = "IdProvincia";
            ddlProvincia2.DataBind();
            ddlProvincia2.Items.Insert(0, new ListItem("[SELECCIONE PROVINCIA]", "0"));
        }

        protected void provinciaSeleccionada2(object sender, EventArgs e)
        {
            int idProvincia = Convert.ToInt32(ddlProvincia2.SelectedValue);
            ddlLocalidad2.DataSource = consultar("SELECT * FROM dbo.Localidades WHERE IdProvincia =" + idProvincia);
            ddlLocalidad2.DataTextField = "NombreLocalidad";
            ddlLocalidad2.DataValueField = "IdLocalidad";
            ddlLocalidad2.DataBind();
            ddlLocalidad2.Items.Insert(0, new ListItem("[SELECCIONAR LOCALIDAD]", "0"));
        }  

        protected void localidadSeleccionada2(object sender, EventArgs e)
        {
          
        }


        public DataSet consultar (string strSql)
        {
            string strConeccion = "Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
            SqlConnection cn = new SqlConnection(strConeccion);
            cn.Open();
            SqlCommand cmd = new SqlCommand(strSql, cn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            cn.Close();
            return ds;
        }

    }
}