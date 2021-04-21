using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto.Entidades;

namespace Instituto.Actividades
{
    public class Profesores:Interfaces.ICRUD<Profesor>
    {
        //public ArrayList alumnos = new ArrayList();
        public List<Profesor> profesores = new List<Profesor>();

        public bool Create(Profesor Entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Profesor Entidad)
        {
            throw new NotImplementedException();
        }

        public List<Profesor> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Profesor Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
