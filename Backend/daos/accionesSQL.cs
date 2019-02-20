using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Backend.modelo;
using System.Data;

namespace Backend.daos
{
    public class accionesSQL
    {

        public bool insert(Fichas f)
        {
            try
            {
                string strCadena = @"server=DESKTOP-593ANJD ; database=pruebas ; USER ID=sa; PASSWORD=root";
                SqlConnection conn = new SqlConnection(strCadena);
                // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);

                conn.Open();

                string insertQuery = "INSERT INTO fichas (nombre, a_paterno, a_materno, n_ficha, fecha, procedencia, opc_1, opc_2, opc_3, promedio) VALUES (@nombre ,@a_paterno, @a_materno, @n_ficha, @fecha, @procedencia, @opc_1, @opc_2, @opc_3, @promedio)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@nombre", f.nombre);
                cmd.Parameters.AddWithValue("@a_paterno", f.a_paterno);
                cmd.Parameters.AddWithValue("@a_materno", f.a_materno);
                cmd.Parameters.AddWithValue("@n_ficha", f.n_ficha);
                cmd.Parameters.AddWithValue("@fecha", f.fecha);
                cmd.Parameters.AddWithValue("@procedencia", f.procedencia);
                cmd.Parameters.AddWithValue("@opc_1", f.opc_1);
                cmd.Parameters.AddWithValue("@opc_2", f.opc_2);
                cmd.Parameters.AddWithValue("@opc_3", f.opc_3);
                cmd.Parameters.AddWithValue("@promedio", f.promedio);
                cmd.ExecuteNonQuery();
               
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }

        public bool delete(int id_ficha)
        {
            try
            {
                string strCadena = @"server=DESKTOP-593ANJD ; database=pruebas ; USER ID=sa; PASSWORD=root";
                SqlConnection con = new SqlConnection(strCadena);
                con.Open();
                string insertQuery = "DELETE FROM fichas WHERE id_ficha = @id_ficha";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@id_ficha", id_ficha);
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
                //Console.ReadKey();
                return false;
            }
        }

        public bool update(Fichas f)
        {
            try
            {
                string strCadena = @"server=DESKTOP-593ANJD ; database=pruebas ; USER ID=sa; PASSWORD=root";
                SqlConnection conn = new SqlConnection(strCadena);
                // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);

                conn.Open();
                string insertQuery = "UPDATE fichas SET nombre = @nombre, a_paterno = @a_paterno, a_materno = @a_materno, n_ficha = @n_ficha, fecha = @fecha, procedencia = @procedencia, opc_1 = @opc_1, opc_2 = @opc_2, opc_3 = @opc_3, promedio = @promedio WHERE id_ficha = @id_ficha";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@id_ficha", f.id_ficha);
                cmd.Parameters.AddWithValue("@nombre", f.nombre);
                cmd.Parameters.AddWithValue("@a_paterno", f.a_paterno);
                cmd.Parameters.AddWithValue("@a_materno", f.a_materno);
                cmd.Parameters.AddWithValue("@n_ficha", f.n_ficha);
                cmd.Parameters.AddWithValue("@fecha", f.fecha);
                cmd.Parameters.AddWithValue("@procedencia", f.procedencia);
                cmd.Parameters.AddWithValue("@opc_1", f.opc_1);
                cmd.Parameters.AddWithValue("@opc_2", f.opc_2);
                cmd.Parameters.AddWithValue("@opc_3", f.opc_3);
                cmd.Parameters.AddWithValue("@promedio", f.promedio);
                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public List<Fichas> getAll()
        //{

        //    List<Fichas> lista = new List<Fichas>();

        //    SqlConnection con = new SqlConnection(@"server = DESKTOP-593ANJD ; database = pruebas; USER ID = sa; PASSWORD = root");

        //    con.Open();

        //    string insertQuery = "SELECT * FROM fichas";
        //    SqlCommand cmd = new SqlCommand(insertQuery, con);

        //    DataSet ds = new DataSet();

        //    cmd.ExecuteNonQuery();

        //    SqlDataAdapter ada = new SqlDataAdapter(cmd);

        //    ada.Fill(ds);

        //    con.Close();

        //    DataTable dt = ds.Tables[0];

        //    Fichas f;

        //    foreach (DataRow r in dt.Rows)
        //    {

        //        f = new Fichas();

        //        f.nombre = (String)r.ItemArray[1];
        //        f.a_paterno = (String)r.ItemArray[2];
        //        f.a_materno = (String)r.ItemArray[3];
        //        f.n_ficha = (int)r.ItemArray[4];
        //        f.fecha = (DateTime)r.ItemArray[5];
        //        f.procedencia = (String)r.ItemArray[6];
        //        f.opc_1 = (String)r.ItemArray[7];
        //        f.opc_2 = (String)r.ItemArray[8];
        //        f.opc_3 = (String)r.ItemArray[9];
        //        f.promedio = (float)r.ItemArray[10];

        //        lista.Add(f);
        //    }

        //    return lista;

        //}


    }
}
