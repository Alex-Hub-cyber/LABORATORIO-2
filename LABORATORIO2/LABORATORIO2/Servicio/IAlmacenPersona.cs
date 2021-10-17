using LABORATORIO2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO2.Servicio
{
   public interface IAlmacenPersona
    {
         void Insertar(AlmacenPersona c);

        public List<AlmacenPersona> ListarPersonas();
    }
}
