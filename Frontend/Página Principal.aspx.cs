using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Backend.daos;

namespace Frontend
{
    public partial class Página_Principal : System.Web.UI.Page
    {
        accionesSQL accion = new accionesSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server = DESKTOP-593ANJD ; database = pruebas; USER ID = sa; PASSWORD = root");

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_Ficha AS ID, nombre AS Nombre, a_paterno AS 'Apellido Paterno', a_materno AS 'Apellido Materno',"+
            "n_ficha AS Número, fecha AS Fecha, procedencia AS 'Escuela de Procedencia', opc_1 AS 'Opción 1',"+
            "opc_2 AS 'Opción 2', opc_3 AS 'Opción 3', promedio AS Promedio FROM fichas", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            grdTabla.DataSource = rdr;
            grdTabla.DataBind();
            con.Close();
        }
        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}