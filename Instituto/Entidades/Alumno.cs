using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto.Actividades;
using Instituto.Entidades.ClasesBase;
using Instituto.Interfaces;

namespace Instituto.Entidades
{
    public class Alumno : Persona
    {
        public override string Actividad()
        {
            return "Estoy realizando una actividad como Alumno, " + base.Actividad();
        }
    }
}