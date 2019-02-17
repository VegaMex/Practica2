using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend.util
{
    public class validadores
    {
        public bool vNumeroFloat(String n)
        {

            String reg = "^([0-9]{2}|(100))(.[0-9]{2}|.[0-9]{1})?$";
            Regex numeroFloat = new Regex(reg);
            

            if (numeroFloat.IsMatch(n))
            {

                if (float.Parse(n) > 0.0 && float.Parse(n) < 100.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            else
            {
                return false;
            }
        }

        public bool vNumero(String n)
        {
            String reg = "^([0-9]{1}|[0-9]{2}|[0-9]{3}|[0-9]{4})$";
            Regex numero = new Regex(reg);

            if (numero.IsMatch(n))
            {
                if (int.Parse(n) > 0 && int.Parse(n) < 5001)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool vNombreApellido(String cadena)
        {
            String reg = "^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\\s]*)+$";
            Regex NA = new Regex(reg);

            if (NA.IsMatch(cadena))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
