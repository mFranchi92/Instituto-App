using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto.Entidades.ClasesBase;

namespace Instituto.Entidades
{
    public class Profesor:Persona
    {
        public override string Actividad()
        {
            return "Estoy realizando una actividad como Profesor, " + base.Actividad();
        }

    }
}
