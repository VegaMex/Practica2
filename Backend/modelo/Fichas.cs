using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.modelo
{
    public class Fichas
    {
        public int id_ficha { get; set; }
        public String nombre { get; set; }
        public String a_paterno { get; set; }
        public String a_materno { get; set; }
        public int n_ficha { get; set; }
        public DateTime fecha { get; set; }
        public String procedencia { get; set; }
        public String opc_1 { get; set; }
        public String opc_2 { get; set; }
        public String opc_3 { get; set; }
        public float promedio { get; set; }
    }
}
