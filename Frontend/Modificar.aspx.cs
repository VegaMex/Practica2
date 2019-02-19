using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Backend.modelo;
using Backend.daos;
using Backend.util;

namespace Frontend
{
    public partial class Modificar : System.Web.UI.Page
    {

        int id_ficha;

        Fichas modeloFicha = new Fichas();
        accionesSQL accion = new accionesSQL();
        validadores val = new validadores();

        List<String> errores = new List<String>();

        protected void Page_Load(object sender, EventArgs e)
        {
            id_ficha = int.Parse(Request.QueryString["id_ficha"]);

            if (!Page.IsPostBack)
            {
                //Response.Write(id_ficha);

                SqlConnection con = new SqlConnection(@"server = WIN-1TUB8M2O9A1\SQLEXPRESS ; database = pruebas; USER ID = sa; PASSWORD = Root123");

                con.Open();

                string insertQuery = "SELECT * FROM fichas WHERE id_ficha = @id_ficha";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@id_ficha", id_ficha);

                DataSet ds = new DataSet();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);

                ada.Fill(ds);

                con.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    Response.Write("El ID no corresponde con ningún registro.");
                }


                foreach (DataRow r in dt.Rows)
                {
                    txtNombre.Text = (String)r.ItemArray[1];
                    txtPaterno.Text = (String)r.ItemArray[2];
                    txtMaterno.Text = (String)r.ItemArray[3];
                    txtFicha.Text = r.ItemArray[4] + "";
                    Calendar1.SelectedDate = (DateTime)r.ItemArray[5];
                    txtProcedencia.Text = (String)r.ItemArray[6];
                    cboOpcion1.SelectedValue = (String)r.ItemArray[7];
                    cboOpcion2.SelectedValue = (String)r.ItemArray[8];
                    cboOpcion3.SelectedValue = (String)r.ItemArray[9];
                    txtPromedio.Text = r.ItemArray[10] + "";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!val.vNumeroFloat(txtPromedio.Text))
            {
                errores.Add("Verifique el promedio ingresado.");
            }

            if (!val.vNumero(txtFicha.Text))
            {
                errores.Add("Verifique el número de ficha.");
            }

            if (!val.vNombreApellido(txtNombre.Text))
            {
                errores.Add("Verifique el nombre.");
            }

            if (!val.vNombreApellido(txtPaterno.Text))
            {
                errores.Add("Verifique el apellido paterno.");
            }

            if (!val.vNombreApellido(txtMaterno.Text))
            {
                errores.Add("Verifique el apellido materno.");
            }


            if (errores.Count == 0)
            {
                    modeloFicha.id_ficha = id_ficha;
                    modeloFicha.nombre = txtNombre.Text;
                    modeloFicha.a_paterno = txtPaterno.Text;
                    modeloFicha.a_materno = txtMaterno.Text;
                    modeloFicha.n_ficha = int.Parse(txtFicha.Text);
                    modeloFicha.fecha = Calendar1.SelectedDate.Date;
                    modeloFicha.procedencia = txtProcedencia.Text;
                    modeloFicha.opc_1 = cboOpcion1.SelectedValue;

                    if (cboOpcion2.SelectedValue == "Ninguna")
                    {
                        modeloFicha.opc_2 = cboOpcion2.SelectedValue;
                        modeloFicha.opc_3 = "Ninguna";
                    }
                    else
                    {
                        modeloFicha.opc_2 = cboOpcion2.SelectedValue;
                        modeloFicha.opc_3 = cboOpcion3.SelectedValue;
                    }

                    modeloFicha.promedio = float.Parse(txtPromedio.Text);
                


                if (accion.update(modeloFicha))
                {
                    Response.Redirect("Página Principal.aspx");

                }
                else
                {
                    Response.Write("No se agregó nada :( ¿Seleccionó una fecha?");
                }
            }
            else
            {
                foreach (var item in errores)
                {
                    Response.Write(item + "<br />");
                }

                errores.Clear();
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Página Principal.aspx");
        }
    }
}