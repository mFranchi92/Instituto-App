using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Instituto.Interfaces
{
    public interface ICRUD<T>
    {
        bool Create(T Entidad);
        List<T> Read();
        bool Update(T Entidad);
        bool Delete(T Entidad);
    }
}
