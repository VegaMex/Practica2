using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Backend.modelo;

namespace Backend.daos
{
    public class accionesSQL
    {

        public bool insert(Fichas f)
        {
            try
            {
                string strCadena = "server=DESKTOP-593ANJD ; database=pruebas ; USER ID=sa; PASSWORD=root";
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
                string strCadena = "server=DESKTOP-593ANJD ; database=pruebas ; USER ID=sa; PASSWORD=root";
                SqlConnection conn = new SqlConnection(strCadena);
                conn.Open();
                string insertQuery = "DELETE FROM fichas WHERE id_ficha = @id_ficha";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@id_ficha", id_ficha);
                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
                //Console.ReadKey();
                return false;
            }
        }

    }
}
