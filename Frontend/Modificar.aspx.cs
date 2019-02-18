using Backend.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class Modificar : System.Web.UI.Page
    {

        int id_ficha;

        protected void Page_Load(object sender, EventArgs e)
        {
            id_ficha = int.Parse(Request.QueryString["id_ficha"]);
            Response.Write(id_ficha);

            SqlConnection con = new SqlConnection(@"server = DESKTOP-593ANJD ; database = pruebas; USER ID = sa; PASSWORD = root");

            con.Open();       

            string insertQuery = "SELECT * FROM fichas WHERE id_ficha = @id_ficha";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@id_ficha", id_ficha);

            DataSet ds = new DataSet();

            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(ds);

            con.Close();

            DataTable dt = ds.Tables[0];


            foreach (DataRow r in dt.Rows)
            {
                txtNombre.Text = (String)r.ItemArray[1];
                txtPaterno.Text = (String)r.ItemArray[2];
                txtMaterno.Text = (String)r.ItemArray[3];
                txtFicha.Text = r.ItemArray[4] + "";
                dateCalendario.SelectedDate = (DateTime)r.ItemArray[5];
                txtProcedencia.Text = (String)r.ItemArray[6];
                cboOpcion1.SelectedValue = (String)r.ItemArray[7];
                cboOpcion2.SelectedValue = (String)r.ItemArray[8];
                cboOpcion3.SelectedValue = (String)r.ItemArray[9];
                txtPromedio.Text = r.ItemArray[10] + "";
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {


        }
    }
}