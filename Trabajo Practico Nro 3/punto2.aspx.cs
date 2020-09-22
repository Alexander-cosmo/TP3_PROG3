using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trabajo_Practico_Nro_3
{
    public partial class punto2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
               
            }
            }

        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            

            if (txtProducto.Text !="")
            {
                if (ddlproducto.SelectedValue == "Igual a:")
                {
                    SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select *from Productos where IdProducto="+txtProducto.Text , morde);
                    morde.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvtabla.DataSource = dr;
                    gvtabla.DataBind();
                    morde.Close();
                }
                if (ddlproducto.SelectedValue == "Mayor a:")
                {
                    SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select *from Productos where IdProducto >" + txtProducto.Text, morde);
                    morde.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvtabla.DataSource = dr;
                    gvtabla.DataBind();
                    morde.Close();
                }
                if (ddlproducto.SelectedValue == "Menor a:")
                {
                    SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select *from Productos where IdProducto <" + txtProducto.Text, morde);
                    morde.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvtabla.DataSource = dr;
                    gvtabla.DataBind();
                    morde.Close();
                }
            }
            ///////////////////////////////////////////////////////
           
            if (txtcategoria.Text != "")
            {
                if (ddlcategoria.SelectedValue == "Igual a:")
                {
                    SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select *from Productos where IdCategoría=" + txtcategoria.Text, morde);
                    morde.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvtabla.DataSource = dr;
                    gvtabla.DataBind();
                    morde.Close();
                }
                if (ddlcategoria.SelectedValue == "Mayor a:")
                {
                    SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select *from Productos where IdCategoría >" + txtcategoria.Text, morde);
                    morde.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvtabla.DataSource = dr;
                    gvtabla.DataBind();
                    morde.Close();
                }
                if (ddlcategoria.SelectedValue == "Menor a:")
                {
                    SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select *from Productos where IdCategoría <" + txtcategoria.Text, morde);
                    morde.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    gvtabla.DataSource = dr;
                    gvtabla.DataBind();
                    morde.Close();
                }
            }

            ///////////////
           
            if(txtcategoria.Text!="" && txtProducto.Text != "")
            {

                switch (ddlproducto.SelectedValue)
                {
                    case "Igual a:":
                        switch (ddlcategoria.SelectedValue)
                        {
                            case "Igual a:":
                                SqlConnection morde = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand cmd = new SqlCommand("Select *from Productos where IdCategoría =" + txtcategoria.Text+"and IdProducto="+ txtProducto.Text, morde);
                                morde.Open();
                                SqlDataReader dr = cmd.ExecuteReader();
                                gvtabla.DataSource = dr;
                                gvtabla.DataBind();
                                morde.Close();
                                break;
                            case "Mayor a:":
                                SqlConnection morde1 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand a = new SqlCommand("Select *from Productos where IdCategoría >" + txtcategoria.Text + "and IdProducto=" + txtProducto.Text, morde1);
                                morde1.Open();
                                SqlDataReader r = a.ExecuteReader();
                                gvtabla.DataSource = r;
                                gvtabla.DataBind();
                                morde1.Close();
                                break;
                            case "Menor a:":
                                SqlConnection morde2 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand b = new SqlCommand("Select *from Productos where IdCategoría <" + txtcategoria.Text + "and IdProducto=" + txtProducto.Text, morde2);
                                morde2.Open();
                                SqlDataReader r2= b.ExecuteReader();
                                gvtabla.DataSource = r2;
                                gvtabla.DataBind();
                                morde2.Close();
                                break;
                        }
                        break;
                    case "Mayor a:":
                        switch (ddlcategoria.SelectedValue)
                        {
                            case "Igual a:":
                                SqlConnection morde3 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand c = new SqlCommand("Select *from Productos where IdCategoría =" + txtcategoria.Text + "and IdProducto>" + txtProducto.Text, morde3);
                                morde3.Open();
                                SqlDataReader r3 = c.ExecuteReader();
                                gvtabla.DataSource = r3;
                                gvtabla.DataBind();
                                morde3.Close();
                                break;
                            case "Mayor a:":
                                SqlConnection morde4 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand d = new SqlCommand("Select *from Productos where IdCategoría >" + txtcategoria.Text + "and IdProducto>" + txtProducto.Text, morde4);
                                morde4.Open();
                                SqlDataReader r4 = d.ExecuteReader();
                                gvtabla.DataSource = r4;
                                gvtabla.DataBind();
                                morde4.Close();
                                break;
                            case "Menor a:":
                                SqlConnection morde5 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand esto = new SqlCommand("Select *from Productos where IdCategoría <" + txtcategoria.Text + "and IdProducto>" + txtProducto.Text, morde5);
                                morde5.Open();
                                SqlDataReader r5 = esto.ExecuteReader();
                                gvtabla.DataSource = r5;
                                gvtabla.DataBind();
                                morde5.Close();
                                break;
                        }
                                break;
                        
                    case "Menor a:":
                        switch (ddlcategoria.SelectedValue)
                        {
                            case "Igual a:":
                                SqlConnection morde6 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand a2 = new SqlCommand("Select *from Productos where IdCategoría =" + txtcategoria.Text + "and IdProducto<" + txtProducto.Text, morde6);
                                morde6.Open();
                                SqlDataReader rr= a2.ExecuteReader();
                                gvtabla.DataSource = rr;
                                gvtabla.DataBind();
                                morde6.Close();
                                break;
                            case "Mayor a:":
                                SqlConnection morde7 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand a3 = new SqlCommand("Select *from Productos where IdCategoría >" + txtcategoria.Text + "and IdProducto<" + txtProducto.Text, morde7);
                                morde7.Open();
                                SqlDataReader rr1 = a3.ExecuteReader();
                                gvtabla.DataSource = rr1;
                                gvtabla.DataBind();
                                morde7.Close();
                                break;
                            case "Menor a:":
                                SqlConnection morde8 = new SqlConnection("Data Source=DESKTOP-UGVRLNH\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                                SqlCommand a4 = new SqlCommand("Select *from Productos where IdCategoría <" + txtcategoria.Text + "and IdProducto<" + txtProducto.Text, morde8);
                                morde8.Open();
                                SqlDataReader cars = a4.ExecuteReader();
                                gvtabla.DataSource = cars;
                                gvtabla.DataBind();
                                morde8.Close();
                                break;
                        }
                                break;


                }





            }







        }

        protected void btnquitarfiltro_Click(object sender, EventArgs e)
        {
            gvtabla.DataSource="";
            gvtabla.DataBind();
            txtcategoria.Text = "";
            txtProducto.Text = "";
        }
    }
}