using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto.Entidades;
using System.Collections;

namespace Instituto.Actividades
{
    public class Alumnos:Interfaces.ICRUD<Alumno>
    {
        //public Alumno[] alumnos= new Alumno[10];
        //public ArrayList alumnos = new ArrayList();
        public List<Alumno> alumnos = new List<Alumno>();

        public bool Create(Alumno Entidad)
        {
            try
            {
                alumnos.Add(Entidad);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void Add(Alumno entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Alumno Entidad)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> Read()
        {
            return alumnos;
        }

        public bool Update(Alumno Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
