using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto.Entidades.ClasesBase
{
    public class Persona
    { 
        public Persona()
        {
            DNI = "VACIO";
            Nombre = "VACIO";
            Apellido = "VACIO";
            Direccion = "VACIO";
            Email = "VACIO";
            Telefono = "VACIO";
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual string Actividad()
        {
            return "Estoy realizando una actividad como Persona";
        }

    }
}
